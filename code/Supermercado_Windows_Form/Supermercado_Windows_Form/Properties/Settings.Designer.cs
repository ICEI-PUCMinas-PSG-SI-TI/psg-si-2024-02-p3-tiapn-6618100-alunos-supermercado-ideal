﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermercado_Windows_Form.Properties
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {
        public string ConnectionString
        {
            get { return ((string)(this["\"Server=sql10.freesqldatabase.com; Database=sql10751637; User ID=sql10751637; Password=nBjeMJwP7I; Port=3306;\""])); }
            set { this["\"Server=sql10.freesqldatabase.com; Database=sql10751637; User ID=sql10751637; Password=nBjeMJwP7I; Port=3306;\""] = value; }
        }

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default
        {
            get
            {
                return defaultInstance;
            }
        }
    }
}
