using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
    class VisaAccount : Account{
        //Fields
        private static double CreditLimit;
        public static double INTEREST_RATE = 0.1995;
        //There are no properties in this class
        //Methods and constructors
        //VisaAccount constructor
        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("VS", balance){
            CreditLimit = creditLimit;
        }
        //Other methods
        public void DoPayment(double amount,Person person){
            Deposit(amount,person);
        }
        public void DoPurchase(double amount, Person person){
            if (amount<CreditLimit){
                Deposit(-amount,person);
            }
        }
        public override void PrepareMonthlyReport(){
            double Interest = (LowestBalance * INTEREST_RATE) / 12;
            Balance = Balance - Interest;
            transactions.Clear();
        }
    }
}
