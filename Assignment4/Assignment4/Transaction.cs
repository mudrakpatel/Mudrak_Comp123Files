using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
        sealed class Transaction{
        //Fields
        public readonly string AccountNumber;
        public readonly double Amount;
        public readonly double EndBalance;
        //Properties
        public readonly Person Originator;
        public readonly DateTime Time;
        //Methods and Constructors
        //Transaction constructor
        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time) {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }
        //Other methods
        //ToString method
        public override string ToString() {
            return String.Format("Originator :>{1:5}  Account Number :>{0:5}\tAmount :>{2:c}  Time :>{3}",AccountNumber,Originator,Amount,Time.ToShortTimeString());
        }
    }
}
