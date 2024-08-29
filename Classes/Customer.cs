using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {

        //public string FirstName;//bu şekilde de tanımlanabilir buna field denir
        
        public int Id { get; set; }// bu şekildeki tanımlamaya da Property denir
        
        private string _firstName;
        public string FirstName { 
            get {return "Sayın "+ _firstName;} 
            set { _firstName = value; } 
        }

        public string TcNo { get; set; }
    }
}
