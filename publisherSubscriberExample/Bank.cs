using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace publisherSubscriberExample
{

    public class TransactionEventArgs : EventArgs
    {
        public Transaction Transaction { get; set; }
    }

    public class Bank
    {

        // 1 - Define a Delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise an event

        //public delegate void TransactionProcessedEventHandler(object source, TransactionEventArgs args);

        public event EventHandler<TransactionEventArgs> TransactionProcessed;


        public void Process(Transaction transaction)
        {
            Console.WriteLine("Transaction processing...");
            Thread.Sleep(2000);

            OnTransactionProcessed(transaction);
        }

        protected virtual void OnTransactionProcessed(Transaction transaction)
        {
            TransactionProcessed?.Invoke(this, new TransactionEventArgs() { Transaction = transaction } );
        }
    }
}
