using System.Speech.Synthesis;
namespace ChatbotAI2
{
    public static class VoicePlayer
    {
        private static SpeechSynthesizer voice = new SpeechSynthesizer();

        public static void PlayGreeting()
        {
            voice.SpeakAsync("Welcome to the Cybersecurity Awareness Bot");
        }

        public static void Speak(string text)
        {
            voice.SpeakAsync(text);
        }
    }
}
