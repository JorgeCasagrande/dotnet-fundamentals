using System;
using System.Collections.Generic;

namespace InterfacesAndInheritance
{
    // INTERFACE: defines a contract that any payment method must implement
    interface IPaymentMethod
    {
        void Pay(decimal amount);
    }

    // ABSTRACT CLASS: provides shared functionality and enforces implementation of 'Pay'
    abstract class PaymentBase : IPaymentMethod
    {
        // Common property to track a transaction
        public string TransactionId { get; set; } = Guid.NewGuid().ToString();

        // ABSTRACT METHOD: must be implemented by derived classes
        public abstract void Pay(decimal amount);

        // Shared method across all payment methods
        public void PrintReceipt()
        {
            Console.WriteLine($"[INFO] Payment processed. Transaction ID: {TransactionId}");
        }
    }

    // INHERITANCE: CreditCardPayment inherits from PaymentBase and implements the Pay method
    class CreditCardPayment : PaymentBase
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paying ${amount} with Credit Card...");
            PrintReceipt(); // Inherited method
        }
    }

    // INHERITANCE: PayPalPayment also inherits from PaymentBase
    class PayPalPayment : PaymentBase
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paying ${amount} with PayPal...");
            PrintReceipt(); // Inherited method
        }
    }

    class Program
    {
        static void Main()
        {
            // POLYMORPHISM: different classes (CreditCard, PayPal) handled via interface
            List<IPaymentMethod> payments = new List<IPaymentMethod>
            {
                new CreditCardPayment(),
                new PayPalPayment()
            };

            // Executing the same method on different objects
            foreach (var payment in payments)
            {
                payment.Pay(100); // Polymorphic call
            }
        }
    }
}
