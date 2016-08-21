using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
        abstract class Account{
        //Fields
        public readonly List<Person> holders = new List<Person>();
        public readonly List<Transaction> transactions = new List<Transaction>();
        private static int LAST_NUMBER=100000;
        //Properties
        public readonly string Number;
        public double Balance { get; set; }
        public double LowestBalance { get; private set; }
        //Methods and Constructors
        //Account constructor
        public Account(string type, double balance) {
            Balance = balance;
            LowestBalance = balance;
            Convert.ToString(LAST_NUMBER);
            Number=type+"-"+ LAST_NUMBER;
            LAST_NUMBER++;
        }
        //Other methods
        public void AddUser(Person person) {
            holders.Add(person);
        }
        public void Deposit(double amount, Person person) {
            Balance = Balance - amount;
            if (Balance < LowestBalance){
                Balance = LowestBalance;
            }
            Transaction TNew = new Transaction("", 0, 0, person, DateTime.Now);
            transactions.Add(TNew);
        }
        public bool IsHolder(string name){
            int ListLength = transactions.Count;
            bool result=true;
            for (int index=0;index<ListLength;index++){
                if (name==holders[index].Name) {
                    result= true;
                }else{
                    result= false;
                }
            }
            return result;
        }
        abstract public void PrepareMonthlyReport();
        //ToString Method
        public override string ToString(){
            string personString = "";
            foreach (Person p in holders) { personString = p.Name; }
            string transactionString = "";
            foreach (Transaction t in transactions) { transactionString += t + "\n"; }
            return String.Format("<<Account no.: {0:5}>>\t<<Holder Name: {1:3}>>\t<<Balance: {2:c}>>\n<<Transactions: {3:2}>>\n",Number,personString,Balance,transactionString);
        }
    }
}
