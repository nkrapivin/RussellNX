namespace RussellNX
{
    public class RuntimeVersion
    {
        public string Version { get; set; }
        public string FullPath { get; set; }
        public bool IsNuBeta { get; set; }

        public override string ToString()
        {
            return $"{Version} - {(IsNuBeta ? "NuBeta" : "Mainline")}";
        }
    }
}
