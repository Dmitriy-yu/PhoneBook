using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PhoneBook.List
{
    class ConnectionString
    {
        public static string ConnStr 
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["PhoneBook.Properties.Settings.ConnStr"].ConnectionString;
            }
        
        }
    }
}

       
