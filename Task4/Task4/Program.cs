using System;
using System.Text.RegularExpressions;

namespace Task4
{
    class Program
    {
        static void ShowRezult(MatchCollection matches)
        {
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    if (match.Value == " " || match.Value == "")
                        continue;
                    else
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine();
            Console.WriteLine();
           
        }

        static void Main(string[] args)
        {
            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа 123 321 224";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            ShowRezult(matches);

            regex = new Regex(@"б\w*");
            matches = regex.Matches(s);
            ShowRezult(matches);

            regex = new Regex(@"\d");
            matches = regex.Matches(s);
            ShowRezult(matches);

            regex = new Regex(@"\d*");
            matches = regex.Matches(s);
            ShowRezult(matches);
            
            regex = new Regex(@"(\w*)а");
            matches = regex.Matches(s);
            ShowRezult(matches);

            regex = new Regex(@"б(\w+)");
            matches = regex.Matches(s);
            ShowRezult(matches);

            Console.WriteLine("Span");
            Span<int> span = new Span<int>(new int[] { 1, 2, 3, 4, 5 });
            Span<int> span1 = span.Slice(2);

            Console.WriteLine("span={ 1, 2, 3, 4, 5 }");
            foreach (var i in span)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            span1[1] += 10;

            Console.WriteLine("span1={ 3, 4, 5 }");
            foreach (var i in span1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
