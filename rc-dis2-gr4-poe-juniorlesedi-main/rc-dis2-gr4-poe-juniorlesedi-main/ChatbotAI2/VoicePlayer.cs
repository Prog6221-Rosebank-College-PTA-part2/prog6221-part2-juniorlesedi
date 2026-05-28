using System.Media;

namespace ChatbotAI2
{
    public class VoicePlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Play();
            }
            catch
            {

            }
        }
    }
}


