using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnProject.Interface;

namespace LearnProject.Class
{
    internal class Transactions: ITransactions
    {
        private string code;
        private string date;
        private double amount;

        public Transactions() { }

        public Transactions(string code, string date, double amount)
        {
            this.code = code;
            this.date = date;
            this.amount = amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", code);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }

        public double getAmount()
        {
            return amount;
        }

        public void setCode(string code)
        {
            this.code = code;
        }
    }
}
