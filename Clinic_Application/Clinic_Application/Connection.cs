using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Clinic_Application
{
    class Connection
    {

            public static string ConnectionString
            {
                get
                {
                    return ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;
                }
            }
        
    }
}
