using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace POS_System.General
{
    class Application_Settings
    {
        public static string ConnectionString()
        {
            return @"Data Source=LAPTOP-N7AOR1VI;Initial Catalog=POS_System;Integrated Security=True";
        }
    }
}
