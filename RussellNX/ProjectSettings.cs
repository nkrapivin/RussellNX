using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RussellNX
{
    public partial class ProjectSettings : Form
    {
        private static string FilePath { get; set; }
        private bool IsNuBeta { get; set; }
        private string MainlineGuid { get; set; }


        public ProjectSettings()
        {
            InitializeComponent();
            ApplyLocalisation();
        }

        public void ApplyLocalisation()
        {
            var ci = CultureInfo.CurrentUICulture.Name;
            if (ci == "ru-RU")
            {
                groupBox1.Text = "Свитч настройки проекта";
                checkNSPPublish.Text = "Проверять проект на ошибки паблишинга? (бесполезно в RussellNX)";
                checkNEXLibs.Text = "Использовать NEX библиотеки? (нужен NEX SDK, бесполезно в RussellNX)";
                checkFileAccessLog.Text = "Логировать доступ к файлам на сд карту? (фиг знает чо ита)";
                checkInterpolation.Text = "Включить интерполяцию пикселей? (если включено, и разрешение меньше свитчевого, будет мыло!)";
                groupBox2.Text = "Режим растягивания картинки игры";
                radioFullScale.Text = "Без подстройки";
                radioKeepAspect.Text = "Подстраивать под соотношение сторон";
                labelTPage.Text = "Максимальный размер текстурной страницы:";
                labelNmetaPath.Text = "Путь к .nmeta:";
                labelRndQuote.Text = "рандомная цитата: ";
                SaveSettingsBtn.Text = "Сохранить и выйти.";
                this.Text = "RussellNX: Настройки проекта.";
                checkUseSplash.Text = "Использовать сплэш? (ТОЛЬКО ДЛЯ 2.3 NUBETA)";
                buttonViewSplash.Text = "Посмотреть сплэш";
                buttonChangeSplash.Text = "Изменить сплэш";
            }
        }

        public ProjectSettings(string projpath) : this()
        {
            var fpath = Path.GetDirectoryName(projpath) + Path.DirectorySeparatorChar + "options" + Path.DirectorySeparatorChar + "switch" + Path.DirectorySeparatorChar + "options_switch.yy";
            ParseFile(fpath);
            labelRndQuote.Text += GenRndQuote();
        }

        public void ParseFile(string path)
        {
            IsNuBeta = true;

            string settings = File.ReadAllText(path);
            SwitchOptions jsettings = JsonConvert.DeserializeObject<SwitchOptions>(settings);
            checkNSPPublish.Checked = jsettings.option_switch_check_nsp_publish_errors;
            checkFileAccessLog.Checked = jsettings.option_switch_enable_fileaccess_checking;
            checkNEXLibs.Checked = jsettings.option_switch_enable_nex_libraries;
            checkInterpolation.Checked = jsettings.option_switch_interpolate_pixels;
            textBoxNmeta.Text = jsettings.option_switch_project_nmeta;
            int scale = jsettings.option_switch_scale;
            if (scale == 0)
            {
                radioFullScale.Checked = false;
                radioKeepAspect.Checked = true;
            }
            else if (scale == 1)
            {
                radioFullScale.Checked = true;
                radioKeepAspect.Checked = false;
            }
            else
            {
                MessageBox.Show("Error when parsing scale!");
            }

            string tpageSize = jsettings.option_switch_texture_page;
            foreach (var item in comboTPageSize.Items)
            {
                if (tpageSize == item.ToString())
                {
                    comboTPageSize.SelectedItem = item;
                    break;
                }
            }

            FilePath = path;

            if (jsettings.resourceVersion == null) IsNuBeta = false;

            if (IsNuBeta)
            {
                checkUseSplash.Checked = jsettings.option_switch_use_splash;
                buttonViewSplash.Tag = jsettings.option_switch_splash_screen;
            }
            else
            {
                // no please.
                checkUseSplash.Enabled = false;
                buttonChangeSplash.Enabled = false;
                buttonViewSplash.Enabled = false;

                MainlineGuid = jsettings.id;
            }
        }

        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            JObject jsettings = new JObject
            {
                // common stuff...
                { "name", "Switch" },
                { "option_switch_check_nsp_publish_errors", checkNSPPublish.Checked },
                { "option_switch_enable_fileaccess_checking", checkFileAccessLog.Checked },
                { "option_switch_enable_nex_libraries", checkNEXLibs.Checked },
                { "option_switch_interpolate_pixels", checkInterpolation.Checked },
                { "option_switch_project_nmeta", textBoxNmeta.Text },
                { "option_switch_scale", radioFullScale.Checked ? 1 : 0 },
                { "option_switch_texture_page", comboTPageSize.SelectedItem.ToString() }
            };

            // finish off with project format stuff...
            if (IsNuBeta)
            {
                jsettings.Add("option_switch_use_splash", checkUseSplash.Checked);
                jsettings.Add("option_switch_splash_screen", (string)buttonViewSplash.Tag);
                jsettings.Add("resourceVersion", "1.0");
                jsettings.Add("resourceType", "GMSwitchOptions");
                jsettings.Add("tags", new JArray());
            }
            else
            {
                jsettings.Add("mvc", "1.0");
                jsettings.Add("modelName", "GMSwitchOptions");
                jsettings.Add("id", MainlineGuid);
            }

            File.WriteAllText(FilePath, jsettings.ToString(), Encoding.UTF8);

            Close();
        }

        private string GenRndQuote()
        {
            string[] quotes;
            var ci = CultureInfo.CurrentUICulture.Name;

            if (ci == "ru-RU")
            {
                quotes = new string[]
                {
                    "не застревать в текстурах",
                    "лучше дома",
                    "мяу",
                    "украинские котохакеры бдят",
                    "гав?",
                    "всем привет",
                    "покупайте деньги",
                    "Ешь вода, пей вода, не будешь срать ты никогда!",
                    "памагите лампачка гарит",
                    "акакой взламать вайфай",
                    "е-батюшка - исповедование онлайн!",
                    "британские мопсохакеры бдят",
                    "фу к*рилл п*ни",
                    "БЕЛКА!"
                };
            }
            else
            {
                quotes = new string[]
                {
                    "If you feel tired, go outside for a walk.",
                    "May contain piracy.",
                    "2.3 support is!!!!",
                    "animals r cute",
                    "why do I suck at making UI design?",
                    "remember to take a break every 30 minutes.",
                    "JSON ABOVE ALL!!@@@!!!!!11111one",
                    "Stay safe, stay home.",
                    "australia's fake lmao",
                    "lojemiru sucks",
                    "blini, truly the yummiest of dishes.", // <-- approved by blini gang.
                    "Don't eat yellow snow",
                    "I'm shocked there isn't a mention of pug",
                    "LUL",
                    "beep boop blini service resumed"
                };
            }


            return quotes[new Random().Next(0, quotes.Length - 1)];
        }

        private void buttonViewSplash_Click(object sender, EventArgs e)
        {
            return;

            Process.Start(UnescapeGMMacros((string)buttonViewSplash.Tag));
        }

        private string UnescapeGMMacros(string _In)
        {
            string _Out = _In;

            // TODO: properly parse macros-es.

            return _Out;
        }

        private void buttonChangeSplash_Click(object sender, EventArgs e)
        {
            return;

            if (openSplashDialog.ShowDialog() == DialogResult.OK)
            {
                var stream = openSplashDialog.OpenFile();
                if (stream != null)
                {
                    var new_stream = File.Open("", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    stream.CopyTo(new_stream);
                    stream.Dispose();

                    new_stream.Flush(true);
                    new_stream.Dispose();
                }
            }
        }
    }
}
