namespace RussellNX
{
    public class SwitchOptions
    {
        // It exists merely for JSON ser/deser purposes.

        // common stuff...
        public bool option_switch_check_nsp_publish_errors { get; set; }
        public bool option_switch_enable_fileaccess_checking { get; set; }
        public bool option_switch_enable_nex_libraries { get; set; }
        public bool option_switch_interpolate_pixels { get; set; }
        public string option_switch_project_nmeta { get; set; }
        public int option_switch_scale { get; set; }
        public string option_switch_texture_page { get; set; }
        public string name { get; set; }

        // pre-NuBeta only
        public string mvc { get; set; }
        public string id { get; set; }
        public string modelName { get; set; }

        // NuBeta only
        public string resourceVersion { get; set; } // mvc
        public object[] tags { get; set; } // ????? you can't even set tags on options...
        public string resourceType { get; set; } // modelName

        // NuBeta Switch only...
        public bool option_switch_use_splash { get; set; }
        public string option_switch_splash_screen { get; set; }
    }
}
