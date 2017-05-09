using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regexy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[] {"pit", "pt", "spot", "Pot", "spate", "peat", "slap two", "part", "respite"};
            string pattern = @"(\w+\s\w+)|(^s\w+)|(\w+i\w+)";
            Console.WriteLine("Zadanie 1");
            CheckRegex(inputs, pattern);

            Console.WriteLine("\n --- \n");

            inputs = new string[] { "rap them", "aleht", "tapeth", "tarpth", "apth", "Apt", "wrap/try", "peth", "sap tray", "tarreth", "87ap9th", "ddapdg", "apothecary", "apples", "shape the"};
            pattern = @"(\w{3}\s\w{4})|(\w+p.t\w+)|(apt\w)";
            Console.WriteLine("Zadanie 2");
            CheckRegex(inputs, pattern);

            Console.WriteLine("\n --- \n");

            inputs = new string[] { "affgfking", "fgok", "rafgkahe", "a fgk", "bafghk", "affgm", "baffgkit", "afffhk", "baffg kit", "Alg.K", "aff gm", "afffhgk"};
            pattern = @"(baf\w+\s?\w+)|(\w+k\w+)";
            Console.WriteLine("Zadanie 3");
            CheckRegex(inputs, pattern);

            Console.WriteLine("\n --- \n");

            inputs = new string[] { "assumes word senses. Within", "in the U.S.A., people often", "does the clustering. In the", "John?\", he often thought, but", "but when? It was hard to tell", "weighed 17.5 grams", "he arrive.\" After she had", "well ... they'd better not", "mess! He did not let it", "A.I. has long been a very", "it wasn't hers!' She replied", "like that\", he thought", "always thought so.) Then", "but W. G. Grace never had much" };
            pattern = @"^[a-z][a-z"+'"'+@"'\s]*[.!?][\w"+'"'+@"')\s]+$";
            Console.WriteLine("Zadanie 4");
            CheckRegex(inputs, pattern);

            Console.WriteLine("\n --- \n");

            inputs = new string[] { "bilbo@bagend.com", "bilbo.baggins@bagend.com", "bilbo.baggins+hobbit@bagend.com", "bilbo@bagend.com.pl", "frodo@bagend.com", "sam@bagend.com", "theringoverthe+chimney@bagend.com" };
            pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";
            Console.WriteLine("Zadanie 5");
            CheckRegex(inputs, pattern);

            Console.WriteLine("\n --- \n");

            inputs = new string[] { "<a>test</a>", "test", "<b>fdsgsdfg</b>", "<i>ewrewr</i>", "kkkk", "aaaa" };
            pattern = @"^";
            Console.WriteLine("Zadanie 6");
            CheckRegex(inputs, pattern);
        }

        public static void CheckRegex (string[] inputs, string pattern)
        {

            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            foreach(string input in inputs)
            {
                MatchCollection matches = rgx.Matches(input);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        Console.WriteLine( match.Value);
                }
            }
            
        }
    }
}
