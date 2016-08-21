using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
    class Person{
        //Fields
        private string Password;
        public readonly string SIN;
        //Properties
        public bool IsAuthenticated { get; private set; }
        public string Name { get; private set; }
        //Methods and Constructors
        //Person constructor
        public Person(string name, string sin) {
           this.Name = name;
            this.SIN = sin;
            Password = sin.Substring(0,3);
        }
        //Other Methods
        public void Login(string password) {
            if (password==Password) {
                IsAuthenticated = true;
            }
        }
        public void Logout() {
            IsAuthenticated = false;
        }
        //ToString method
        public override string ToString(){
            return String.Format("Name: {0:5}  Is authenticated ? >{1}",Name,IsAuthenticated);
        }
    }
}
