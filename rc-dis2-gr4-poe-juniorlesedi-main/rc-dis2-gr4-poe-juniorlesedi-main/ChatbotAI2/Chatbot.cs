using System;
using System.Collections.Generic;

public class Chatbot
{
    private string userName;
    private Dictionary<string, string> responses = new Dictionary<string, string>()
    {
    { "how are you", "I am good! I am here to help you stay safe online." },
    { "purpose", "My purpose is to teach you about cybersecurity." },
    { "password", "Use strong passwords with numbers, symbols, and capital letters." },
    { "phishing", "Phishing is when scammers trick you into giving your information." },
    { "link", "Do not click on links you do not trust." },
    { "safe browsing", "Always check if a website is secure before using it." },
    { "scam", "Online scams try to steal your money or personal details." },
    { "virus", "A virus can damage your computer. Always install antivirus software." },
    { "malware", "Malware is harmful software that can steal your data." },
    { "privacy", "Do not share personal information online with strangers." },
    { "2fa", "Two-factor authentication adds extra security to your accounts." },
    { "otp", "Never share your OTP code with anyone." },
    { "wifi", "Avoid using public WiFi for banking or sensitive information." },
    { "update", "Always update your apps and system to stay protected." }
};

    public void StartChat()
    {
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(userName))
        {
            userName = "User";
        }

        Console.WriteLine($"\nHello {userName}! Welcome to the Cybersecurity Bot.\n");

        while (true)
        {
            Console.Write($"{userName}: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please type something...");
                continue;
            }

            if (input == "exit")
            {
                Console.WriteLine("Bot: Goodbye! Stay safe online.");
                break;
            }

            bool found = false;

            foreach (var item in responses)
            {
                if (input.Contains(item.Key))
                {
                    Console.WriteLine("Bot: " + item.Value);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Bot: I didn’t understand that. Can you try again?");
            }
        }
    }
}