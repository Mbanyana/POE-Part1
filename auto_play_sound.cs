namespace POE_Part1
{
    using System;
    using System.IO;
    using System.Media;
    internal class auto_play_sound
    {
        

        public auto_play_sound()
        {
            // Get the base directory and find the sound file path
            string fullLocation = AppDomain.CurrentDomain.BaseDirectory;
            string newPath = fullLocation.Replace("bin\\Debug\\", "");
            string fullPath = Path.Combine(newPath, "greeting.wav");

            try
            {
                // Create a new SoundPlayer and play the sound synchronously
                using (SoundPlayer player = new SoundPlayer(fullPath))
                {
                    player.PlaySync();  // PlaySync ensures that the sound is played before continuing
                }
            }
            catch (Exception error)
            {
                // Handle any errors that occur during sound loading or playing
                Console.WriteLine("Error playing sound: " + error.Message);
            }
        }
    }
}

        
    
