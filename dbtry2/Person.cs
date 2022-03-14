using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbtry2
{
   public class Person
    {
        public string id { get; set; }
        public string username { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public string nammeNmail 
        {
            get 
            {
                return $"{fName} {lName},({ email }) ";
            }
        }

        public string allDetails
        {
            get
            {
                return $"{id},{fName} {lName},{email},{username},{password}";
            }
            
        }
    }
}
