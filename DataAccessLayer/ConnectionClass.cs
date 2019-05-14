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
        
        //connect to database for storing the information and data of bug tracking system

        public static String ConnectionString
        {
            get { return "Data Source=(local);Initial Catalog=Bugtrackingapplication;Integrated Security=True"; }
            
        }
    }
}
