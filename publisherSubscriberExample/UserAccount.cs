using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisherSubscriberExample
{
    class UserAccount
    {
        public void OnTransactionProcessed(object source, TransactionEventArgs args)
        {
            Console.WriteLine("User Account: Receiving money..." + args.Transaction.Amount);
        }
    }
}
