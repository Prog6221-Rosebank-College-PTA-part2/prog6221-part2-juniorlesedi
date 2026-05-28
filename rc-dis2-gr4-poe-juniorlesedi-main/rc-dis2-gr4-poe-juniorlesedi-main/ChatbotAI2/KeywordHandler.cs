using System;
using System.Collections.Generic;
//this is a keyword handler
namespace ChatbotAI2
{

    public class KeywordHandler
    {
        private Dictionary<string, List<string>> keywordResponses;
        private Random random;

        public KeywordHandler()
        {
            random = new Random();

            keywordResponses = new Dictionary<string, List<string>>();

            keywordResponses.Add("password", new List<string>
            {
                "Use strong passwords with symbols and numbers.",
                "Never use your name in your password.",
                "Change your passwords regularly for better security."
            });

            keywordResponses.Add("phishing", new List<string>
            {
                "Avoid clicking suspicious email links.",
                "Scammers often pretend to be banks or trusted companies.",
                "Always verify email addresses before responding."
            });

            keywordResponses.Add("malware", new List<string>
            {
                "Avoid clicking suspicios links.",
                "Hackers use it to steal sensetive data .",
                "Always run the latest versions of your operating systema,browserd, and apps to patch security vulnerabilities."
            });

            keywordResponses.Add("privacy", new List<string>
            {
                "Review your social media privacy settings.",
                "Avoid sharing personal information publicly.",
                "Use two-factor authentication for extra protection."
            });

            keywordResponses.Add("scam", new List<string>
            {
                "Never send money to unknown people online.",
                "Online scams often create fake urgency.",
                "Be careful of offers that seem too good to be true."
            });
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();

            foreach (var keyword in keywordResponses.Keys)
            {
                if (input.Contains(keyword))
                {
                    List<string> responses = keywordResponses[keyword];
                    int index = random.Next(responses.Count);
                    return responses[index];
                }
            }

            return "I'm not sure I understand. Can you try rephrasing?";
        }
    }
}