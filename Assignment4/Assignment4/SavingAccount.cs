using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
    class SavingAccount:Account{
        //Fields
        public static double COST_PER_TRANSACTION = 0.05;
        public static double INTEREST_RATE = 0.015;
        //There are no properties in this class
        //Methods and constructors
        //SavingAccount constructor   
        public SavingAccount(double balance=0) : base("SV", balance){

        }
        //Other methods
        public new void Deposit(double amount,Person person){            
            if (holders.Contains(person)){
                base.Deposit(amount, person);
            }
        }
        public void Withdraw(double amount, Person person){
            if (person.IsAuthenticated==true){
                if (amount < Balance){
                    base.Deposit(-amount, person);
                }
            }
        }
        public override void PrepareMonthlyReport(){
            double NumberOfTransactions = Balance / COST_PER_TRANSACTION;
            double ServiceCharge = NumberOfTransactions * COST_PER_TRANSACTION;
            double Interest = (Balance * INTEREST_RATE) / 12;
            Balance = (Balance + Interest) - ServiceCharge;
            transactions.Clear();
        }        
    }
}
