using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisherSubscriberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var transaction = new Transaction(){Amount = 42.32f};
            var bank = new Bank();
            var user = new UserAccount();
            var nsaSnoop = new NSASnoop();

            bank.TransactionProcessed += user.OnTransactionProcessed; // registering the handler
            bank.TransactionProcessed += nsaSnoop.OnTransactionProcessed;

            bank.Process(transaction);


            Console.WriteLine("\n");
        }
    }
}
