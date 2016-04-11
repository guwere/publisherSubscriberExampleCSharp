using System;

namespace publisherSubscriberExample
{
    class NSASnoop
    {
        public void OnTransactionProcessed(object source, TransactionEventArgs args)
        {
            Console.WriteLine("NSASnoop : snooping on user account ..." + args.Transaction.Amount);
        }
    }
}