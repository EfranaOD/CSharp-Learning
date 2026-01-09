using System;
using System.Text.RegularExpressions;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myEmail = "My email is efrana@example.com";

            //IsMatch:
            bool hasEmail = Regex.IsMatch(myEmail, @"\w+@\w+\.\w+");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(hasEmail);
            Console.ResetColor();

            //Match:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string text = "Order@123";
            Console.WriteLine(Regex.Match(text, @"\d+")); // 123
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string greet = "Hello world";
            Console.WriteLine(Regex.Match(greet, @"\w+$")); // world
            Console.ResetColor();

            string sentence = "Is there really any meaning in this act we call living.";
            string[] matches = Regex.Split(sentence, @"\s+");
            foreach (string match in matches)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine
                    (match);
                Console.ResetColor();
            }

            //?
            Console.WriteLine(Regex.Match("color", @"colou?r"));  // matches "color" (no 'u')
            Console.WriteLine(Regex.Match("colour", @"colou?r"));  // matches "colour" (has 'u')

            string[] words = { "cat", "cats" };
            foreach (var word in words)
                Console.WriteLine(Regex.IsMatch(word, @"cats?"));

            string[] phones = { "555-1234", "(212)555-1234" };
            foreach (var p in phones)
                Console.WriteLine(Regex.IsMatch(p, @"(\(\d{3}\))?\d{3}-\d{4}"));

            //| Symbol   | Meaning                                        |
            //| -------  | ---------------------------------------------- |
            //| `\(`     | Matches a literal `(` character                |
            //| `\d{ 3}` | Matches 3 digits                               |
            //| `\)`     | Matches a literal `)` character                |
            //| `(...)`  | Grouping — “treat this whole part as one unit” |

            string[] greetings = { "good morning", "morning" };
            foreach (var g in greetings)
                Console.WriteLine(Regex.IsMatch(g, @"(good )?morning"));

            //Final Breakdown — @"^\d+(\.\d+)?$"
            //| Part      |                                    Meaning                                    |
            //| --------- | ----------------------------------------------------------------------------- |
            //| `^`       | The match must start at the beginning of the string.                          |
            //| `\d +`    | One or more digits — the integer part.                                        |
            //| `(` … `)` | Group the following section together so `?` applies to the* whole*group.      |
            //| `\.`      | A literal dot (escaped, because `.` normally means “any character”).          |
            //| `\d +`    | One or more digits after the decimal — the fractional part.                   |
            //| `)?`      | Make the entire group optional — may appear once or not at all.               |
            //| `$`       | The match must end at the end of the string.                                  |

            //| Symbol   |       Meaning     |  Example  |          Matches          |
            //| :------: | :---------------- | :-------- | :------------------------ |
            //|   `*`    | 0 or more         | `a *`     | `""`, `"a"`, `"aaaa"`     |
            //|   `+`    | 1 or more         | `a +`     | `"a"`, `"aaaa"` ( `""`)   |
            //|   `?`    | 0 or 1            | `a ?`     | `""`, `"a"`               |
            //|  `{ n}`  | exactly n         | `a{ 3}`   | `"aaa"`                   |
            //|  `{ n,}` | at least n        | `a{ 2,}`  | `"aa"`, `"aaaaaa"`        |
            //| `{ n,m}` | between n and m   | `a{ 2,4}` | `"aa"`, `"aaa"`, `"aaaa"` |

            //Extract and Mask Sensitive Data

            string input = "Contact us at support@example.com or admin@test.org.\ncall +91-9876543210 for assistance.";

            bool hasEmaill = Regex.IsMatch(input, @"\w+@\w+\.\w+");
            // hasEmaill used to avoid conflict with earlier practice variable name

            if (!hasEmaill)
            {
                Console.WriteLine("No emails detected");
            }
            else
            {
                Console.WriteLine("Email/'s detected!");
            }

            var matchess = Regex.Matches(input, @"\w+@\w+\.\w+");
            Console.WriteLine("extracted emails: ");
            foreach (Match m in matchess)
            {
                Console.WriteLine(m.Value + " ");
            }
            foreach (Match m in matchess) 
            {
                Match grp = Regex.Match(m.Value, @"(\w+)@(\w+)\.\w+");
                Console.WriteLine("User Name: " + grp.Groups[1].Value + " | Domain Name: " + grp.Groups[2].Value);
            }

            Console.WriteLine(
                Regex.Replace(
                    input,
                    @"(\+91\-)\d+(\d{2})(?=\D)",
                    "$1********$2"
                )
            );

        }
    }
}
