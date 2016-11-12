namespace xxdswinform.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"), CompilerGenerated]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings defaultInstance = ((Settings) SettingsBase.Synchronized(new Settings()));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [ApplicationScopedSetting, DebuggerNonUserCode, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://0x00/xxdsExam/FileService.asmx")]
        public string xxdswinform_WebReference_FileService
        {
            get
            {
                return (string) this["xxdswinform_WebReference_FileService"];
            }
        }

        [ApplicationScopedSetting, DebuggerNonUserCode, SpecialSetting(SpecialSetting.WebServiceUrl), DefaultSettingValue("http://0x00/xxdsExam/StudentService.asmx")]
        public string xxdswinform_WebReference1_StudentService
        {
            get
            {
                return (string) this["xxdswinform_WebReference1_StudentService"];
            }
        }
    }
}

