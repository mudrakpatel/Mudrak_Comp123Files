using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
    static class Bank{
      //Fields
      static private List<Account> Accounts ;
        static private List<Person> Persons ;
        //There are no properties in this class
        //Constructors and other methods
        //Bank constructor
        static Bank(){
            CreatePersons();
            CreateAccounts();
      }
        private static void CreatePersons(){
            Persons = new List<Person>(){
                new Person("Narendra","1234-5678"),
                new Person("Ilia", "2345-6789"),
                new Person("Tom", "3456-7890"),
                new Person("Syed", "4567-8901"),
                new Person("Arben", "5678-9012"),
                new Person("Patrick", "6789-0123"),
                new Person("Yin", "7890-1234"),
                new Person("Hao", "8901-2345"),
                new Person("Ilir", "9012-3456")
            };
        }
        static void CreateAccounts(){
            Accounts = new List<Account>(){
                new VisaAccount(),
                new VisaAccount(50,200),
                new SavingAccount(5000),
                new SavingAccount(),
                new CheckingAccount(2000),
                new CheckingAccount(1500,true)
            };
        }
        public static void PrintAccounts(){
            foreach (Account a in Accounts) { Console.WriteLine(a); }
        }
        public static void PrintPersons(){
            foreach (Person p in Persons) { Console.WriteLine(p); }
            
        }
        public static Person GetPerson(string name){
            Person TemporaryPerson = null;
            
            foreach(Person p in Persons) {
                if (p.Name == name)
                {
                    TemporaryPerson = p;
                }
                    }
            return TemporaryPerson;
        }
        public static Account GetAccount(string number){
            Account TemporaryAccount = null;
            foreach(Account a in Accounts)
            {
                if(a.Number == number)
                {
                    TemporaryAccount = a;
                }
            }
            
            return TemporaryAccount;
        }
    }
}
