using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Security.Cryptography; //MD5

//INI library
using IniParser;
using IniParser.Model;
using IniParser.Parser;
using System.Threading;

namespace RussellNX
{
    public partial class MainForm : Form
    {
        public static string RuntimeVersion = "2.2.3.344";
        public static string RuntimePath = Environment.ExpandEnvironmentVariables("%PROGRAMDATA%") + "\\GameMakerStudio2\\Cache\\runtimes\\runtime-" + RuntimeVersion;
        public static string FriendlyYYPName = "";
        public static string GameIconPath = Application.StartupPath + "\\default_icon.jpg";
        public static string RNXVersionString = "1.2.1";
        public static int BuildState = 0;
        public static int StringsCount = 0;

        public MainForm()
        {
            InitializeComponent();

            //Check for write access first.
            try
            {
                File.WriteAllText(Application.StartupPath + "\\dircheck.txt", "");
            }
            catch (Exception e)
            {
                //for some reason this messagebox doesn't wanna show up (??)
                MessageBox.Show("ERROR!\nYour current RussellNX directory doesn't have Read Write permissions.\nPlease move RussellNX to Desktop, Documents, Downloads heck, everywhere else!\n\nException: " + e.ToString(), "Idiot Check Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
                return;
            }
            File.Delete(Application.StartupPath + "\\dircheck.txt");
            //I mean, if this check passed, this file should exist, if check failed, program exits before this line executes.

            if (Debugger.IsAttached) Text += " (Running inside Visual Studio)";

            if (!File.Exists(Application.StartupPath + "\\RussellNX.ini"))
            {
                DefaultSettings();
            }
            else LoadSettings();

            //Set version label
            RNXVersionLabel.Text = "RussellNX Version: " + RNXVersionString;

            if (!File.Exists(GameIconPath))
            {
                MessageBox.Show("ERROR!\ndefault_icon.jpg is missing\nPlease redownload RussellNX!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
                return;
            }

            IconPicBox.Image = new Bitmap(GameIconPath);

            //Check for 2.2.3.344 Runtime
            //other runtimes maybe later idk...
            if (!File.Exists(RuntimePath + "\\bin\\GMAssetCompiler.exe"))
            {
                MessageBox.Show("ERROR!\nThe version of runtime you chose is not installed! Please make sure to download it in GMS2 in File->Preferences->Runtime Feeds->Master (the tool uses 2.2.3.344 as default)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Environment.Exit(-1); //-1 because an error has occured.
                //return;
            }

            MessageBox.Show("WARNING:\n1) This tool is highly experimental!\n2) Installing Custom NSPs may get your Switch banned, be careful!", "Important Warning.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Cleanup temp dirs
            for (int i = 1000; i < 9999; i++)
            {
                if (Directory.Exists(Application.StartupPath + "\\TEMPDIR" + i.ToString()))
                    Directory.Delete(Application.StartupPath + "\\TEMPDIR" + i.ToString(), true);
            }

            //Check for keys.txt here
            if (!File.Exists(KeysBox.Text))
            {
                MessageBox.Show("Please specify your keys.txt file after clicking OK", "No keys.txt specified!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenFileDialog KeysChooseDialog = new OpenFileDialog();
                KeysChooseDialog.Filter = "All Files|*.*";

                if (KeysChooseDialog.ShowDialog() == DialogResult.OK)
                {
                    KeysBox.Text = KeysChooseDialog.FileName;
                }
            }

            prnt("RussellNX Version " + RNXVersionString + " is waiting for you, master!");
        }

        private void IconChooseBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your icon must be a JPEG (.jpg) 256x256 image!", "Icon format message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog IconChooseDialog = new OpenFileDialog();
            IconChooseDialog.Filter = "JPEG Icon (*.jpg)|*.jpg";

            if (IconChooseDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap NXAppIcon = new Bitmap(IconChooseDialog.FileName);
                var NXAppIconW = NXAppIcon.Width;
                var NXAppIconH = NXAppIcon.Height;

                //Icon MUST BE 256x256 c'mon!
                if ((NXAppIconW != 256) || (NXAppIconH != 256))
                {
                    MessageBox.Show("Your icon size is invalid!\nIt should be 256x256", "Error in loading icon.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IconPicBox.Image = NXAppIcon;
                    GameIconPath = IconChooseDialog.FileName;
                }
            }
        }

        private void OpenProjectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ProjectChooseDialog = new OpenFileDialog();
            ProjectChooseDialog.Filter = "GMS2 Project (*.yyp)|*.yyp";

            if (ProjectChooseDialog.ShowDialog() == DialogResult.OK)
            {
                ProjectPathBox.Text = ProjectChooseDialog.FileName;
                FriendlyYYPName = Path.GetFileNameWithoutExtension(ProjectChooseDialog.FileName);
                prnt("GameName: " + FriendlyYYPName);
                //MessageBox.Show(FriendlyYYPName);
            }
        }


        //Thanks Microsoft for this function! Very helpful :33
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void prnt(string log)
        {
            CheckForIllegalCrossThreadCalls = false;

            //Special command that cleans the LogBox.
            if (log == "$LOG_CLEAN") { LogBox.Text = ""; StringsCount = 0; }
            else
            LogBox.Text += log + "\n"; //Append text

            //Scroll to the end.
            StringsCount++;
            if (StringsCount > 21)
            {
                LogBox.Focus();
                LogBox.SelectionStart = LogBox.Text.Length;
            }
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {

            //Idiot checks.
            if (!File.Exists(ProjectPathBox.Text))
            {
                MessageBox.Show("Project file does not exist!\nPlease select a valid project file.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(GameIconPath))
            {
                MessageBox.Show("Icon does not exist!\nPlease select your icon again.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(KeysBox.Text))
            {
                MessageBox.Show("keys.txt does not exist!\nPlease select your keys.txt file again.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(RuntimePath + "\\bin\\GMAssetCompiler.exe"))
            {
                MessageBox.Show("This path is invalid, maybe your runtime version is invalid?", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string prebuiltPath = "";
            if (!Directory.Exists(Application.StartupPath + @"\runners\build" + RuntimeVersion))
            {
                MessageBox.Show("ERROR! Nik didn't built an ExeFS for your runtime version,\ncould you please try a different one?\n\n(or contact nik at nik#5351 and tell him the version you want)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else prebuiltPath = Application.StartupPath + @"\runners\build" + RuntimeVersion;

            //Check for PwnieCastle.Crypto.dll
            if (RuntimeVersion != "2.2.3.344") //this version has public_key vuln, newer don't.
            {
                string hash = "";
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(RuntimePath + "\\bin\\BouncyCastle.Crypto.dll"))
                    {
                        hash = BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToUpperInvariant();
                        stream.Close();
                        stream.Dispose();
                    }
                }
                prnt("hash of BouncyCastle.Crypto.dll: " + hash);
                if (hash != "2DF050A077C999DC0BBF21EB7E7DFA70") //hash of PwnieCastle.Crypto.Dll
                {
                    DialogResult result = MessageBox.Show("Hey, your runtime is not vulnerable to public_key\nAnd it doesn't have PwnieCastle installed, would you like to copy over PwnieCastle.Crypto.dll from RussellNX directory to bypass /m=switch license check?", "PwnieCastle Message", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        prnt("User aborted installation of PwnieCastle.Crypto.dll, cannot proceed!");
                        return;
                    }
                    else if (result == DialogResult.Yes)
                    {
                        if (!File.Exists(Application.StartupPath + "\\PwnieCastle.Crypto.dll"))
                        {
                            prnt("ERROR! PwnieCastle library doesn't exist, redownload RussellNX! Building aborted!");
                            return;
                        }
                        prnt("Installing PwnieCastle.Crypto.dll...");
                        File.Copy(RuntimePath + @"\bin\BouncyCastle.Crypto.dll", RuntimePath + @"\bin\BouncyCastle.Crypto.bak");
                        File.Copy(Application.StartupPath + @"\PwnieCastle.Crypto.dll", RuntimePath + @"\bin\BouncyCastle.Crypto.dll", true);
                        prnt("Done! Backup is saved in {RuntimeDir}\\bin\\BouncyCastle.Crypto.dll");
                    }
                    else prnt("?????????? try again, please.");
                }
            }

            //Let the build begin >:)
            prnt("$LOG_CLEAN"); //clean LogBox

            prnt("BUILD BEGIN:");

            //Make a temp build directory.
            prnt("Making Temp Directory");
            Random ind = new Random();
            int ind2 = ind.Next(1000, 9999);
            string TempDirectoryPath = Application.StartupPath + "\\TEMPDIR" + ind2.ToString();
            if (Directory.Exists(TempDirectoryPath)) Directory.Delete(TempDirectoryPath);
            Directory.CreateDirectory(TempDirectoryPath);

            //Put some files...
            prnt("Copying stuff");
            DirectoryCopy(prebuiltPath, TempDirectoryPath + "\\build", true);

            prnt("Generating GMAssetCompiler args str"); //Ass is intentional, please laugh...
            string GMACPath = RuntimePath + "\\bin\\GMAssetCompiler.exe";
            string BaseProjPath = RuntimePath + "\\BaseProject\\BaseProject.yyp";
            string GameProjPath = ProjectPathBox.Text;
            string GameName = FriendlyYYPName;
            string CacheDir = TempDirectoryPath + "\\CelesteCacheDir" + (ind2 - 10).ToString();
            string TempDir = TempDirectoryPath + "\\CelesteTempDir" + (ind2 + 10).ToString();
            string OutputDir = TempDirectoryPath + "\\build\\romfs";
            string INIDir = TempDirectoryPath + "\\build\\romfs\\options.ini";

            string LicensePlistPath = Application.StartupPath + "\\license"; //public_key'd already ;)

            //shader fix, fuck yoyo
            Directory.CreateDirectory(TempDir);
            Directory.CreateDirectory(CacheDir);
            Directory.CreateDirectory(OutputDir);

            string GMACArgs = @" /c /zpex /mv=1 /iv=0 /rv=0 /bv=0 /j=8 /gn=""" + GameName + @""" /td=""" + TempDir + @""" /cd=""" + CacheDir + @""" /zpuf=""" + LicensePlistPath + @""" /m=switch /tgt=144115188075855872 /cvm /bt=exe /rt=vm /sh=False /nodnd /cfg=default /o=""" + OutputDir + @""" /optionsini=""" + INIDir + @""" /baseproject=""" + BaseProjPath + @""" " + @"""" + GameProjPath + @""" /preprocess=""" + CacheDir + @"""";
            prnt(GMACArgs);
            //return;

            string args = "";

            //Compile game
            
            prnt("\nPreprocessing game project...\n");

            Process process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WorkingDirectory = RuntimePath + "\\bin";
            process.StartInfo.FileName = GMACPath;
            process.StartInfo.Arguments = GMACArgs;
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                prnt(process.StandardOutput.ReadLine());
                Application.DoEvents(); //update LogBox richtextbox
            }
            process.WaitForExit();

            GMACArgs = @" /c /zpex /mv=1 /iv=0 /rv=0 /bv=0 /j=8 /gn=""" + GameName + @""" /td=""" + TempDir + @""" /cd=""" + CacheDir + @""" /zpuf=""" + LicensePlistPath + @""" /m=switch /tgt=144115188075855872 /cvm /bt=exe /rt=vm /sh=False /nodnd /cfg=default /o=""" + OutputDir + @""" /optionsini=""" + INIDir + @""" /baseproject=""" + BaseProjPath + @""" " + @"""" + GameProjPath + @"""";
            process.StartInfo.Arguments = GMACArgs;
            prnt(GMACArgs);

            prnt("\nBuilding your project...\n");
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                prnt(process.StandardOutput.ReadLine());
                Application.DoEvents(); //update LogBox richtextbox
            }
            process.WaitForExit();

            prnt("\nBuilding NSP...");
            File.Copy(GameIconPath, TempDirectoryPath + "\\build\\control\\icon_AmericanEnglish.dat"); //copy the icon
            File.Copy(GameIconPath, TempDirectoryPath + "\\build\\control\\icon_Japanese.dat"); //...twice
            var exefsdir = @".\build\exefs";
            var romfsdir = @".\build\romfs";
            var logodir = @".\build\logo";
            var controldir = @".\build\control";
            args = @" -k """ + KeysBox.Text + @""" --keygeneration 6 --titleid " + TitleIDBox.Text + @" --titlename """ + GameNameBox.Text + @""" --titlepublisher """ + AuthorBox.Text + @""" --exefsdir " + exefsdir + @" --romfsdir " + romfsdir + @" --logodir " + logodir + @" --controldir " + controldir + @" --nopatchnacplogo";
            prnt(args);
            process.StartInfo.Arguments = args;
            process.StartInfo.FileName = Application.StartupPath + "\\hacbrewpack.exe";
            process.StartInfo.WorkingDirectory = TempDirectoryPath;
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                prnt(process.StandardOutput.ReadLine());
                Application.DoEvents(); //update LogBox richtextbox
            }
            process.WaitForExit();

            //free things
            process.Close();
            process.Dispose();

            prnt("\nDone!");
            prnt("Your NSP is at " + TempDirectoryPath + "\\hacbrewpack_nsp");
            Process.Start("explorer.exe", TempDirectoryPath + "\\hacbrewpack_nsp"); //open the build directory.
            prnt("Explorer window with your file should be opened...");
            prnt("Thanks for using RussellNX and god bless the United States of France!");
        }

        private void KeysBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog KeysChooseDialog = new OpenFileDialog();
            KeysChooseDialog.Filter = "All Files|*.*";

            if (KeysChooseDialog.ShowDialog() == DialogResult.OK)
            {
                KeysBox.Text = KeysChooseDialog.FileName;
            }

            KeysChooseDialog.Dispose();
        }

        private void LoadSettings()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Application.StartupPath + "\\RussellNX.ini");
            ProjectPathBox.Text = data["Main"]["AppYYPPath"];
            TitleIDBox.Text = data["Main"]["AppID"];
            GameNameBox.Text = data["Main"]["AppName"];
            AuthorBox.Text = data["Main"]["AppAuthor"];
            VersionBox.Text = data["Main"]["AppVersion"];
            KeysBox.Text = data["Main"]["AppKeysPath"];
            GameIconPath = data["Main"]["AppIconPath"];
            RuntimeVersion = data["Main"]["RuntimeVersion"];
            RuntimeVersionBox.Text = RuntimeVersion;
            RuntimePath = Environment.ExpandEnvironmentVariables("%PROGRAMDATA%") + "\\GameMakerStudio2\\Cache\\runtimes\\runtime-" + RuntimeVersion;
            FriendlyYYPName = Path.GetFileNameWithoutExtension(ProjectPathBox.Text);
            prnt("GameName: " + FriendlyYYPName);
            prnt("RuntimePath: " + RuntimePath);
            prnt("Loaded!");
        }
        private void SaveSettings()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(Application.StartupPath + "\\RussellNX.ini");
            data["Main"]["AppYYPPath"] = ProjectPathBox.Text;
            data["Main"]["AppID"] = TitleIDBox.Text;
            data["Main"]["AppName"] = GameNameBox.Text;
            data["Main"]["AppAuthor"] = AuthorBox.Text;
            data["Main"]["AppVersion"] = VersionBox.Text;
            data["Main"]["AppKeysPath"] = KeysBox.Text;
            data["Main"]["AppIconPath"] = GameIconPath;
            data["Main"]["RuntimeVersion"] = RuntimeVersion;
            data["AppVersion"]["RNXVer"] = RNXVersionString;
            parser.WriteFile(Application.StartupPath + "\\RussellNX.ini", data);
            prnt("Saved!");
        }
        private void DefaultSettings()
        {
            //Migrate KeysFilePath 1.0 config
            if (File.Exists(Application.StartupPath+"\\KeysFilePath"))
            {
                string kpath = File.ReadAllText(Application.StartupPath + "\\KeysFilePath");
                KeysBox.Text = kpath;
                File.Delete(Application.StartupPath + "\\KeysFilePath");
            }

            //Populate default settings file.
            string fname = Application.StartupPath + "\\RussellNX.ini";
            File.WriteAllText(fname, "");
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(fname);
            data.Sections.AddSection("Main");
            data.Sections.GetSectionData("Main").Comments.Add("This is a RussellNX configuration file, edit with caution.");
            parser.WriteFile(fname, data);
            prnt("Default RussellNX.ini was made.");
            Focus(); //Focus MainForm
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save settings
            prnt("Saving...");
            SaveSettings();

        }

        private void RuntimeVersionBox_TextChanged(object sender, EventArgs e)
        {
            RuntimeVersion = RuntimeVersionBox.Text;
            RuntimePath = Environment.ExpandEnvironmentVariables("%PROGRAMDATA%") + "\\GameMakerStudio2\\Cache\\runtimes\\runtime-" + RuntimeVersionBox;
        }
    }
}
