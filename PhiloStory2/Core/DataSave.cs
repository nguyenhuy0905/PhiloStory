using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PhiloStory2.Core
{
    internal class DataSave:ConfigurationSection
    {
        [ConfigurationProperty("DarkMode", DefaultValue = false)]
        public bool DarkMode {
            get { return (bool)this["DarkMode"]; } 
            set { this["DarkMode"] = value; } 
        }
        [ConfigurationProperty("NeutralMode", DefaultValue = true)]
        public bool NeutralMode
        {
            get { return (bool)this["NeutralMode"]; }
            set { this["NeutralMode"] = value; }
        }
    }
}
