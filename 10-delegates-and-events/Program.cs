using System;

namespace DelegatesAndEvents
{
    // Define a delegate
    delegate void NotificationDelegate(string message);

    class Notifier
    {
        // Define an event based on the delegate
        public event NotificationDelegate OnNotify;

        public void TriggerNotification(string message)
        {
            Console.WriteLine("[Notifier] Triggering notification...");
            OnNotify?.Invoke(message); // Notify all subscribers
        }
    }

    class Program
    {
        static void Main()
        {
            Notifier notifier = new Notifier();

            // Subscribe methods to the event
            notifier.OnNotify += SendEmail;
            notifier.OnNotify += SendSMS;

            // Trigger the event
            notifier.TriggerNotification("System update available!");

            // Unsubscribe a method
            notifier.OnNotify -= SendSMS;

            Console.WriteLine("\n[INFO] Triggering again with one less subscriber...");
            notifier.TriggerNotification("Maintenance scheduled for tonight.");
        }

        // These methods match the delegate signature
        static void SendEmail(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }

        static void SendSMS(string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }
}
