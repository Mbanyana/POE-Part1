
using System;
using System.Drawing;
using System.IO;

internal class Logo
{
    public Logo()
    {
        // Display the ASCII art logo first
        DisplayLogo();

        // Display the greeting message
        DisplayGreeting();
    }

    // Method to display the image as ASCII art
    private void DisplayLogo()
    {
        // Get the path of the logo image
        string pathProject = AppDomain.CurrentDomain.BaseDirectory;
        string newPathProject = pathProject.Replace("bin\\Debug\\", "");
        string fullPath = Path.Combine(newPathProject, "Logo.jpg");

        try
        {
            // Load the image
            Bitmap image = new Bitmap(fullPath);

            // Resize the image to fit into the console
            image = new Bitmap(image, new Size(80, 50));

            // Convert the image to ASCII art
            for (int height = 0; height < image.Height; height++)
            {
                for (int width = 0; width < image.Width; width++)
                {
                    // Get pixel color
                    Color pixelColor = image.GetPixel(width, height);

                    // Calculate the grayscale value
                    int colorValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    // Map the grayscale value to an ASCII character
                    char asciiChar = colorValue > 200 ? '.' :
                                     colorValue > 150 ? '*' :
                                     colorValue > 100 ? '0' :
                                     colorValue > 50 ? '#' : '@';

                    // Print the ASCII character
                    Console.Write(asciiChar);
                }
                // Move to the next line after each row
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            // Handle any errors that occur during image loading or processing
            Console.WriteLine("Error loading or processing the image: " + ex.Message);
        }
    }

    // Public method to display the ASCII greeting text
    public void DisplayGreeting()
    {
        string greetingMessage = @"
##############################################
#__        __   _                          _ #
#\ \      / /__| | ___ ___  _ __ ___   ___| |#
# \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ |#
#  \ V  V /  __/ | (_| (_) | | | | | |  __/_|#
#   \_/\_/ \___|_|\___\___/|_| |_| |_|\___(_)#
##############################################                                                                                                                                                                                                                                                                                              
";
        // Output the greeting message
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(greetingMessage);
        Console.ResetColor();
    }
}







