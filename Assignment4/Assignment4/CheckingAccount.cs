using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
    class CheckingAccount:Account{
        //Fields
        public static double COST_PER_TRANSACTION=0.05;
        public static double INTEREST_RATE = 0.005;
        private static bool HasOverdraft;
        //No properties!
        //Constructors and other methods
        //CheckingAccount constructor
        public CheckingAccount(double balance=0,bool hasOverdraft=false):base("CK",balance){
            HasOverdraft = hasOverdraft;
        }
        //Other methods
        public new void Deposit(double amount,Person person){
            if (HasOverdraft==true) {
                base.Deposit(amount,person);
            }
        }
        public void Withdraw(double amount, Person person){
            if (person.IsAuthenticated == true){
                if (amount < Balance || HasOverdraft == true){
                    base.Deposit(-amount,person);
                }
            }
        }
        public override void PrepareMonthlyReport(){
            double NumberOfTransactions = Balance / COST_PER_TRANSACTION;
            double ServiceCharge = NumberOfTransactions * COST_PER_TRANSACTION;
            double Interest = (Balance * INTEREST_RATE) / 12;
            Balance = (Balance + Interest)-ServiceCharge;
            transactions.Clear();
        }
    }
}
