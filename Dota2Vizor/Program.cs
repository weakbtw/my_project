using System;
using System.Collections.Generic;

public class Chat
{
    private List<string> messages = new List<string>();

    public void PostMessage(string user, string message)
    {
        messages.Add(user + ": " + message);
    }

    public void DisplayChat()
    {
        foreach (var message in messages)
        {
            Console.WriteLine(message);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Chat chat = new Chat();

        while (true)
        {
            Console.Write("Enter your name: ");
            string user = Console.ReadLine();

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            chat.PostMessage(user, message);

            Console.WriteLine("\nChat:");
            chat.DisplayChat();
            Console.WriteLine();
        }
    }
}
