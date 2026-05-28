using System;
using System.Windows.Forms;

namespace ChatbotAI2
{
    public partial class MainForm : Form
    {
        private KeywordHandler keywordHandler;
        private MemoryManager memoryManager;
        private SentimentAnalyzer sentimentAnalyzer;

        private string lastTopic = "";

        public MainForm()
        {
            InitializeComponent();

            keywordHandler = new KeywordHandler();
            memoryManager = new MemoryManager();
            sentimentAnalyzer = new SentimentAnalyzer();

            VoicePlayer.PlayGreeting();

            rtbChat.AppendText(@"

  _____       _                _           
 / ____|     | |              | |          
| |    _   _ | |__    ___ _ __| |__   ___  
| |   | | | || '_ \  / _ \ '__| '_ \ / _ \ 
| |___| |_| || |_) ||  __/ |  | |_) | (_) | 
 \_____\__, ||_.__/  \___|_|  |_.__/ \___/ 
         __/ |                              
        |___/                               

================================================
        CYBERSECURITY AWARENESS BOT
================================================

Hello! Ask me anything about cybersecurity.

");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                return;
            }

            rtbChat.AppendText("You: " + userInput + "\n");

            string response = ProcessInput(userInput);

            rtbChat.AppendText("Bot: " + response + "\n\n");

            txtUserInput.Clear();
        }

        private string ProcessInput(string input)
        {
            string lowerInput = input.ToLower();

            if (lowerInput.Contains("hi my name is"))
            {
                string name = input.Substring(input.IndexOf("is") + 2).Trim();
                memoryManager.UserName = name;

                return "Nice to meet you, " + name + ". I'll remember your name.";
            }

            if (lowerInput.Contains("i like"))
            {
                string topic = input.Substring(input.IndexOf("like") + 4).Trim();
                memoryManager.FavouriteTopic = topic;

                return "Great! I'll remember that you are interested in " + topic + ".";
            }

            string sentiment = sentimentAnalyzer.DetectSentiment(input);

            if (sentiment == "im worried")
            {
                return "It's understandable to feel worried. Remember to avoid suspicious links and protect your passwords.";
            }

            if (sentiment == "frustrated")
            {
                return "Cybersecurity can feel overwhelming sometimes, but taking small steps helps a lot.";
            }

            if (sentiment == "curious")
            {
                return "That's great! Learning about cybersecurity helps you stay safe online.";
            }

            if (lowerInput.Contains("another tip") ||
                lowerInput.Contains("tell me more") ||
                lowerInput.Contains("explain more"))
            {
                if (lastTopic != "")
                {
                    return keywordHandler.GetResponse(lastTopic);
                }
                else
                {
                    return "Please ask about a cybersecurity topic first.";
                }
            }

            if (lowerInput.Contains(" wha is password"))
            {
                lastTopic = "password";
            }
            else if (lowerInput.Contains("what is phishing"))
            {
                lastTopic = "phishing";
            }
            else if (lowerInput.Contains("what is privacy"))
            {
                lastTopic = "privacy";
            }
            else if (lowerInput.Contains("what is scam"))
            {
                lastTopic = "scam";
            }

            string keywordResponse = keywordHandler.GetResponse(input);

            if (memoryManager.UserName != null)
            {
                keywordResponse = memoryManager.UserName + ", " + keywordResponse;
            }

            return keywordResponse;
        }
    }
}