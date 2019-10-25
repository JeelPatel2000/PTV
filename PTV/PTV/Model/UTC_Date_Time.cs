using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTV.Model
{
    public class UTC_Date_Time
    {
        public static string getDateTime()
        {
            //string now = DateTime.Now.ToString();
            string now = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() +  "T" + DateTime.Now.Hour.ToString() + "%3A" + DateTime.Now.Minute.ToString() + "%3A" + DateTime.Now.Second.ToString() +"Z";
            
            return now;
        }

        
    }
}
