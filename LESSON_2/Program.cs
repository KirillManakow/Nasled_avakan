using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON_2
{   internal class Program
    {
        static void Main(string[] args)
        {
            Client[] clientDataBase = new Client[]
           {
                    new Investor("Сорокин", 250178.597m, 20.15),
                    new Investor("Манаков",  12178.867m, 18.75),
                    new Creditor("Мухин",  121780.867m, 18.75, 120000),
                    new Creditor("Орешкова",  12178.867m, 18.75, 578.89m),
                    new Organization("ООО 'ЗОЧЕМ'", 123456785, 7894623.7834m),
                    new Organization("ООО 'ЗАТЕМ'", 456456785, 7894623.7834m)
           };
            foreach (Client client in clientDataBase)
            {
                client.PrintInfo();
                Console.WriteLine();
            }
            Console.Read();
        }
    }

    public abstract class Client
    {
        public abstract void PrintInfo();
    }
    public class Investor : Client
    {
        public string Surname { get; set; }
        public decimal DepositAmount { get; set; }
        public double DepositInterest { get; set; }

        public Investor(string surname, decimal depositAmount, double depositInteres)
        {
            Surname = surname;
            DepositAmount = depositAmount;
            DepositInterest = depositInteres;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия вкладчика: {0}", Surname);
            Console.WriteLine("Размер вклада: {0}", DepositAmount);
            Console.WriteLine("Процент по вкладу: {0}", DepositInterest);
        }
    }
    public class Creditor : Client
    {
        public string Surname { get; set; }
        public decimal CreditAmount { get; set; }
        public double CreditInterest { get; set; }
        public decimal CreditBalance { get; set; }

        public Creditor(string surname, decimal creditAmount, double creditInterest,
                        decimal creditBalance)
        {
            Surname = surname;
            CreditAmount = creditAmount;
            CreditInterest = creditInterest;
            CreditBalance = creditBalance;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Фамилия вкладчика: {0}", Surname);
            Console.WriteLine("Размер кредита: {0}", CreditAmount);
            Console.WriteLine("Процент по кредиту: {0}", CreditInterest);
            Console.WriteLine("Остаток долга: {0}", CreditBalance);
        }
    }
    public class Organization : Client
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public decimal AccountAmount { get; set; }

        public Organization(string name, int accountNumber, decimal accountAmount)
        {
            Name = name;
            AccountNumber = accountNumber;
            AccountAmount = accountAmount;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("Название организации: {0}", Name);
            Console.WriteLine("Номер счета: {0}", AccountNumber);
            Console.WriteLine("Сумма на счету: {0}", AccountAmount);
        }
    }
}