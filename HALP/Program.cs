using System;

namespace HALP
{
    class Program
    {
        static void Main(string[] args)
        {
            var trx1 = new Transaction()
            {
                Sender = "Keybored",
                Receiver = "CryptoKnights",
                ID = int.Parse(Guid.NewGuid().ToString()),
                Amount = 1000,
                Fee = 100
            };

            var trx2 = new Transaction()
            {
                Sender = "Jeremy",
                Receiver = "Cain",
                ID = int.Parse(Guid.NewGuid().ToString()),
                Amount = 500,
                Fee = 50
            };

            var trx3 = new Transaction()
            {
                Sender = "Tony",
                Receiver = "Bologna",
                ID = int.Parse(Guid.NewGuid().ToString()),
                Amount = 90000,
                Fee = 9000
            };

            Transaction[] Transactions = { trx1, trx2, trx3 };

            //asume previous hash is empty
            var prevHash = System.Text.Encoding.UTF8.GetBytes("");

            //create new Block
            new Block(0, String.Empty.ConvertToBytes(), Transactions, "Admin");


        }
    }
}
