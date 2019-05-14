using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class ConnectionClass
    { 
        

        public static String ConnectionString
        {
            get { return "Data Source=(local);Initial Catalog=Bugtrackingapplication;Integrated Security=True"; }
            
        }
    }
}
