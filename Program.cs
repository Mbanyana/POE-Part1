using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part1
{
    public class Program
    {
        // Function to simulate typing effect
        static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50); // Adjust delay for typing effect
            }
        }
        static void Main(string[] args)
        {
            new auto_play_sound() { };
            new Logo() { };
            


            
        

            ArrayList userInputs = new ArrayList();
            ArrayList botResponses = new ArrayList();

            // Responses for greetings and asking of name
            userInputs.Add("hello");
            botResponses.Add("Hello there! How can I assist you today?");



            userInputs.Add("how are you");
            botResponses.Add("I'm just a bot, but I'm doing well, thank you!");

            userInputs.Add("bye");
            botResponses.Add("Goodbye! See you next time!");

            userInputs.Add("your name");
            botResponses.Add("I am a friendly chatbot, I don't have a name yet.");

            // Security questions
            userInputs.Add("protect phishing");
            botResponses.Add("To protect yourself from phishing, avoid clicking on suspicious links, don't give out personal information via email or phone, and always verify the source before entering sensitive data.");

            userInputs.Add("phishing");
            botResponses.Add("Phishing is when someone pretends to be a legitimate organization or individual in order to steal sensitive information such as passwords, credit card numbers, and more. Always be cautious when receiving unsolicited emails or messages asking for personal information.");

            userInputs.Add("strong password");
            botResponses.Add("A strong password is at least 12 characters long and includes a mix of uppercase and lowercase letters, numbers, and symbols. Avoid using common words, names, or easily guessable information.");

            userInputs.Add("safe password");
            botResponses.Add("To keep your passwords safe, use a password manager to generate and store complex passwords. Enable two-factor authentication whenever possible, and never reuse passwords across different accounts.");

            userInputs.Add("what is ransomware");
            botResponses.Add("Ransomware is a type of malware that encrypts your files and demands payment for the decryption key. It's crucial to back up your files and avoid opening untrusted attachments.");

            userInputs.Add("how do I protect myself from ransomware");
            botResponses.Add("To protect yourself from ransomware, regularly back up your files, don't click on suspicious links, and always update your software to patch any security vulnerabilities.");

            userInputs.Add("what is two-factor authentication");
            botResponses.Add("Two-factor authentication (2FA) is a security measure that requires two forms of identification to access your accounts, typically something you know (a password) and something you have (like a phone or security token).");


            // Display welcome message
            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect("Hello! I am a simple chatbot. What is your name?\n");
            Console.ResetColor();

            // Ask for the user name and ensure it's not empty
            string userName = "";
            while (string.IsNullOrEmpty(userName))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypeEffect("Please enter your name: ");
                Console.ResetColor();
                userName = Console.ReadLine()?.Trim();

                // If the user doesn't enter anything, ask again
                if (string.IsNullOrEmpty(userName))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("Bot: I need a valid name to continue.\n");
                    Console.ResetColor();
                }
            }

            // To greet the user
            Console.ForegroundColor = ConsoleColor.Green;
            TypeEffect($"Hello, {userName}! I am here to assist you. Type 'exit' to end the chat.\n");
            Console.ResetColor();

            // Infinite loop for conversation
            while (true)
            {
                // A user input
                Console.ForegroundColor = ConsoleColor.Magenta;
                TypeEffect($"{userName}: ");
                Console.ResetColor();
                string userInput = Console.ReadLine()?.Trim();

                // Check if user input is valid and not empty
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("Bot: Please enter something.\n");
                    Console.ResetColor();
                    continue;
                }

                // Exit condition
                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypeEffect("Goodbye! Have a great day.\n");
                    Console.ResetColor();
                    break;
                }

                bool foundResponse = false;

                // 
                string userInputLower = userInput.ToLower();

                // Loop to check if there is any key words
                for (int i = 0; i < userInputs.Count; i++)
                {
                    // Convert keywords to lowercase and check if the input contains the keyword
                    string keyword = userInputs[i].ToString().ToLower();

                    // Check if the user input contains the keyword 
                    if (userInputLower.Contains(keyword))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        TypeEffect("Bot: " + botResponses[i] + "\n");
                        Console.ResetColor();
                        foundResponse = true;
                        break;
                    }
                }

                // If no matching keyword was found type message
                if (!foundResponse)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypeEffect("Bot: Sorry, I don't understand that. Can you rephrase?\n");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}







