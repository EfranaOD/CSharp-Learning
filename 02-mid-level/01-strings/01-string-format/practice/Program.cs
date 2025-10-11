using System;

namespace practice
{
    internal class Program
    {
        class Conversation
        {
            public void Start()
            {
                int userChoice = DisplayTopicChoice();
                if (userChoice == 5) { Console.WriteLine("Have a nice day!"); return; }
                string topic = GetTopicFromChoice(userChoice);
                string detail = AskDetailForTopic(userChoice, topic, out string? format);
                ShowFormattedResponse(format, detail, topic);
            }
            private int DisplayTopicChoice()
            {
                Console.WriteLine("Pick your topic of discussion:");
                Console.WriteLine("Talk about your\n1. Pet\n2. Anime\n3. Study\n4. Random\n5. Nothing\n");
                int userChoice;

                bool isSuccess = int.TryParse(Console.ReadLine(), out userChoice);
                if (!isSuccess) { Console.WriteLine("Invalid input.\nDefault choice '5' is selectd."); userChoice = 5; }
                return userChoice;
            }
            private string GetTopicFromChoice(int userChoice)
            {
                string? topic = null;

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("\nWhat is your pet?");
                        topic = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                        break;

                    case 2:
                        Console.WriteLine("\nWhat is your favorite anime?");
                        topic = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                        break;

                    case 3:
                        Console.WriteLine("\nWhat are you studying?");
                        topic = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                        break;

                    case 4:
                        Console.WriteLine("\nWhat is your hobby?");
                        topic = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                        break;

                    case 5:
                        Console.WriteLine("\nOkay!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        userChoice = 5;
                        break;
                }

                return topic!;
            }
            private string AskDetailForTopic(int userChoice, string topic, out string? format)
            {
                string? userAns = null;
                format = null;

                if (userChoice == 1)
                {
                    Console.Write("\nYour pet's name: ");
                    userAns = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                    format = "{0}'s such a cute name. Having {1} as a pet is great!";
                }
                else if (userChoice == 2)
                {
                    Console.Write($"\nWho is your favorite character in {topic}: ");
                    userAns = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                    format = "{0}'s a well written character. No wonder thats your favorite character in {1}.";
                }
                else if (userChoice == 3)
                {
                    Console.Write($"\nWhat is your favorite subject: ");
                    userAns = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                    format = "{0} is a really tough subject. I couldn't have expected that given you're studying {1}.";
                }
                else if (userChoice == 4)
                {
                    Console.Write($"\nApart from {topic}, what else do you like doing in your free time: ");
                    userAns = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
                    format = "{1} being your favorite thing to do daily, no wonder {0} is your second pick.";
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("\nHave a nice day!");
                    return string.Empty;
                }

                return userAns!;
            }
            private void ShowFormattedResponse(string? format, string detail, string topic)
            {
                if(string.IsNullOrWhiteSpace(topic)) { topic = "[unknown]"; }
                if (string.IsNullOrWhiteSpace(detail)) { detail = "[unknown]"; }
                if (!string.IsNullOrWhiteSpace(format))
                {
                    string finalResult = string.Format(format, detail, topic);
                    Console.WriteLine("\n" + finalResult);
                }
            }
        }
        public static void Main(string[] args)
        {
            Conversation conversation = new Conversation();
            conversation.Start();

            Console.WriteLine("\n\nExiting...");
        }
    }
}