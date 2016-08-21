using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Assignment 4; Comp123; Mudrak Patel ;Tarun Rana ;Khushdial Singh ;Iqbal Gill

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args) {
            //testing the visa account
            Bank.PrintAccounts();
            Bank.PrintPersons();

            //a visa account

            try {
                VisaAccount a = (VisaAccount)Bank.GetAccount("VS-100000");
                Person p1, p2, p3, p4, p5, p6, p7, p8, p9;
                p1 = Bank.GetPerson("Narendra");
                p2 = Bank.GetPerson("Ilia");
                p3 = Bank.GetPerson("Tom");
                p1.Login("123");
                p2.Login("234");
                p3.Login("345");
                a.AddUser(p1);
                a.AddUser(p2);
                a.AddUser(p3);
                a.DoPurchase(125, p1);
                a.DoPurchase(200, p2);
                a.DoPurchase(15, p3);
                a.DoPurchase(12.5, p1);
                a.DoPayment(400, p1);
                Console.WriteLine(a);
            





            a = (VisaAccount)Bank.GetAccount("VS-100001");
            p4 = Bank.GetPerson("Syed");
            p5 = Bank.GetPerson("Arben");
            p4.Login("456");
            p5.Login("567");
            p3.Login("345");
            a.AddUser(p4);
            a.AddUser(p5);
            a.AddUser(p3);
            a.DoPurchase(225, p4);
            a.DoPurchase(200, p5);
            a.DoPurchase(15, p3);
            a.DoPurchase(12.5, p1); //should not work
            a.DoPayment(400, p1);
            Console.WriteLine(a);

            //a saving account
            SavingAccount b = (SavingAccount)Bank.GetAccount("SV-100003");
            p6 = Bank.GetPerson("Patrick");
            p7 = Bank.GetPerson("Yin");
            b.AddUser(p3);
            b.AddUser(p6);
            p6.Login("678");
            b.Deposit(300, p3);
            b.Deposit(32.90, p3);
            b.Deposit(50, p6);
            b.Withdraw(111.11, p6);
            Console.WriteLine(b);

            b = (SavingAccount)Bank.GetAccount("SV-100002");
            p6 = Bank.GetPerson("Patrick");
            p7 = Bank.GetPerson("Yin");
            b.AddUser(p3);
            b.AddUser(p6);
            b.AddUser(p7);
            p6.Login("678");
            b.Withdraw(300, p3);
            b.Withdraw(32.90, p3);
            b.Withdraw(50, p6);
            b.Withdraw(111.11, p6);
            Console.WriteLine(b);

            //a checking account
            CheckingAccount c = (CheckingAccount)Bank.GetAccount("CK-100005");
            p8 = Bank.GetPerson("Hao");
            p9 = Bank.GetPerson("Ilir");
            p8.Login("890");
            p9.Login("901");
            c.AddUser(p6);
            c.AddUser(p8);
            c.AddUser(p9);
            c.Deposit(33.33, p8);
            c.Deposit(40.44, p8);
            c.Withdraw(450, p9);
            c.Withdraw(500, p8);
            c.Withdraw(645, p8);
            c.Withdraw(850, p9);
            Console.WriteLine(c);


            c = (CheckingAccount)Bank.GetAccount("CK-100004");
            p8 = Bank.GetPerson("Hao");
            p9 = Bank.GetPerson("Ilir");
            p8.Login("890");
            p9.Login("901");
            c.AddUser(p6);
            c.AddUser(p8);
            c.AddUser(p9);
            c.Deposit(33.33, p8);
            c.Deposit(40.44, p8);
            c.Withdraw(450, p9);
            c.Withdraw(500, p8);
            c.Withdraw(645, p8);
            c.Withdraw(850, p9);        //should not work
            Console.WriteLine(c);
        }
            catch (Exception e)
            {
                e.ToString();
                Console.WriteLine(e.StackTrace);
            }

        }
    }
}
