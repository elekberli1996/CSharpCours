using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    { //proportyler

        //enkapsulasyon get eden zaman baska bisey yapmak icin kullanilir
        public int Id { get; set; }

        private string _firstName;
        public string FirstName {
            get { return "Sayin"+ _firstName; } 
            set {_firstName=value; } }

        public string LastName { get; set; }

        public  string City{ get; set; }

    }
}
