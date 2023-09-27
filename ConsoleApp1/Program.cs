using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favMovie;
            favMovie = "THE MATRIX";
            Console.WriteLine("Hello, my name is Rowen Ellis, my favourite movie is " + favMovie.ToLower() + ", it's the best movie!");
            Console.WriteLine();

            if (favMovie.Contains("THE"))
            {
                Console.WriteLine("True, '" + favMovie.ToLower() + "'" + " contains the word 'the'.");
            }
            else
            {
                Console.WriteLine("False, '" + favMovie.ToLower() + "'" + " doesn't contain the word 'the'.");
            }
            Console.WriteLine();
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            string favQuote = "'THERE'S NO PLACE LIKE HOME.'";
            Console.WriteLine(favQuote.ToLower());
            favQuote = favQuote.Replace("A", "");
            favQuote = favQuote.Replace("E", "");
            favQuote = favQuote.Replace("I", "");
            favQuote = favQuote.Replace("O", "");
            favQuote = favQuote.Replace("U", "");
            favQuote = favQuote.Replace("Y", "");
            Console.WriteLine(favQuote.ToLower());
            Console.WriteLine(favQuote.ToUpper());

            Console.WriteLine();

            Console.WriteLine("             ,                                                                       `;,;.;,;.;.'");
            Console.WriteLine("       (`.  : \\               __..----..__                                           ..:;:;::;: ");
            Console.WriteLine("        `.`.| |:          _,-':::''' '  `:`-._                                  ..--''' '' ' ' '''--.  ");
            Console.WriteLine("          `.:\\||       _,':::::'         `::::`-.                            /' .   .'        '.   .`\\");
            Console.WriteLine("            \\`|    _,':::::::'     `:.     `':::`.                          | /    /            \\   '.|");
            Console.WriteLine("             ;` `-''  `::::::.                  `::\\                        | |   :             :    :|");
            Console.WriteLine("          ,-'      .::'  `:::::.         `::..    `:\\                     .'| |   :             :    :|");
            Console.WriteLine("        ,' /_) -.            `::.           `:.     |                    ,: /\\ \\.._\\ __..===..__/_../ /`.");
            Console.WriteLine("      ,'.:     `    `:.        `:.     .::.          \\                 |'' |  :.|  `'          `'  |.'  ::.");
            Console.WriteLine(" __,-'   ___,..-''-.  `:.        `.   /::::.         |                  |   |  ''|    :'';          | ,  `''\\");
            Console.WriteLine("|):'_,--'           `.    `::..       |::::::.      ::\\                |.:  \\/  | /'-.`'   ':'.-'\\ |  \\,   |");
            Console.WriteLine(" `-'                 |`--.:_::::|_____\\::::::::.__  ::|                | '  /  /  | / |...   | \\ |  |  |';'|");
            Console.WriteLine("                     |   _/|::::|      \\::::::|::/\\  :|                \\ _ |:.|  |_\\_|`.'   |_/_|  |.:| _ |");
            Console.WriteLine("                     /:./  |:::/        \\__:::):/  \\  :\\             /,.,.|' \\__       . .      __/ '|.,.,\\");
            Console.WriteLine("                   ,'::'  /:::|        ,'::::/_/    `. ``-.__                | ':`.`----._____.---'.'   |");
            Console.WriteLine("                  ''''   (//|/\\      ,';':,-'         `-.__  `'--..__       \\   `:\"\"\"-------'\"\"' |   |");
            Console.WriteLine("                                                           `''---::::'         ',-,-',             .'-=,=,");
        }
    }
}