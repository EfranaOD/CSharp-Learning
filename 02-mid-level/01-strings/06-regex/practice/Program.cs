using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string myEmail = "My email is efrana@example.com";

            bool hasEmail = Regex.IsMatch(myEmail, @"\w+@\w+.\w+");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(hasEmail);
            Console.ResetColor();

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
            foreach(string match in matches)
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

            //| Symbol  | Meaning                                        |
            //| ------- | ---------------------------------------------- |
            //| `\(`    | Matches a literal `(` character |
            //| `\d{ 3}` | Matches 3 digits |
            //| `\)`    | Matches a literal `)` character |
            //| `(...)` | Grouping — “treat this whole part as one unit” |

            string[] greetings = { "good morning", "morning" };
            foreach (var g in greetings)
                Console.WriteLine(Regex.IsMatch(g, @"(good )?morning"));

            //Final Breakdown — @"^\d+(\.\d+)?$"
            //| Part      |                                    Meaning                                    |
            //| --------- | ----------------------------------------------------------------------------- |
            //| `^`       | The match must **start at the beginning** of the string.                      |
            //| `\d +`    | One or more digits — the** integer part * *.                                  |
            //| `(` … `)` | **Group * *the following section together so `?` applies to the* whole*group. |
            //| `\.`      | A * *literal dot * *(escaped, because `.` normally means “any character”).    |
            //| `\d +`    | One or more digits after the decimal — the** fractional part * *.             |
            //| `)?`      | Make the entire group** optional** — may appear once or not at all.           |
            //| `$`       | The match must **end at the end** of the string.                              |

            //| Symbol   |       Meaning     |  Example  |          Matches          |
            //| :------: | :---------------- | :-------- | :------------------------ |
            //|   `*`    | 0 or more         | `a *`     | `""`, `"a"`, `"aaaa"`     |
            //|   `+`    | 1 or more         | `a +`     | `"a"`, `"aaaa"` ( `""`) |
            //|   `?`    | 0 or 1            | `a ?`     | `""`, `"a"`               |
            //|  `{ n}`  | exactly n         | `a{ 3}`   | `"aaa"`                   |
            //|  `{ n,}` | at least n        | `a{ 2,}`  | `"aa"`, `"aaaaaa"`        |
            //| `{ n,m}` | between n and m   | `a{ 2,4}` | `"aa"`, `"aaa"`, `"aaaa"` |



        }
    }
}
