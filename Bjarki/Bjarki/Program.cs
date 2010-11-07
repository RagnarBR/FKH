using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpBag;
using SharpBag.Strings;
using SharpBag.IO;
using SharpBag.FK;
using SharpBag.Math;
using SharpBag.Math.Converters;
using System.IO;
using System.Text.RegularExpressions;

namespace Bjarki
{
    class Program
    {
        static void Main(string[] args)
        {
            D17();

            Console.ReadLine();
        }

        static void D17()
        {
            Console.Write("Farþegafjöldi: ");
            int n = Console.ReadLine().ToInt();

            /*int r60 = 0;
            int r30 = 0;
            int r20 = 0;

            while (n > 30)
            {
                r60++;
                n -= 60;
            }

            while (n > 20)
            {
                r30++;
                n -= 30;
            }

            while (n > 0)
            {
                r20++;
                n -= 20;
            }

            if (r60 > 0) Console.WriteLine(r60 + " stk 60 manna rúta");
            if (r30 > 0) Console.WriteLine(r30 + " stk 30 manna rúta");
            if (r20 > 0) Console.WriteLine(r20 + " stk 20 manna rúta");*/

            var q = from r20 in 0.To(3)
                    from r30 in 0.To(2)
                    from r60 in 0.To(3)
                    let sum = r20 * 20 + r30 * 30 + r60 * 60
                    let r = r20 + r30 + r60
                    where sum >= n
                    orderby r, sum
                    //orderby r60 + r30 + r20, r60 descending, r30 descending, r20 descending
                    select new { r20, r30, r60, sum };

            var b = q.First();

            if (b.r60 > 0) Console.WriteLine(b.r60 + " stk 60 manna rúta");
            if (b.r30 > 0) Console.WriteLine(b.r30 + " stk 30 manna rúta");
            if (b.r20 > 0) Console.WriteLine(b.r20 + " stk 20 manna rúta");
        }

        static void D16()
        {
            string[] tilbod = File.ReadLines("D16.txt", Encoding.Default).Where(l => l.StartsWith("*")).ToArray();

            Console.WriteLine("Frábær 3 fyrir 2 tilboð:");

            foreach (string t in tilbod)
            {
                List<string> o = t.Split(' ').ToList();
                o.RemoveAt(0);
                int k = o.Last().ToInt();
                o.RemoveAt(o.Count - 1);
                Console.WriteLine(String.Join(" ", o.ToArray()) + " - " + (k * 2) + " krónur");
            }
        }

        static void D15()
        {
            Console.Write("Strengur sem leita á í: ");
            string s = Console.ReadLine();
            Console.Write("Strengur sem leita á að: ");
            string l = Console.ReadLine();

            if (s.Contains(l))
            {
                Console.WriteLine("Textinn " + l + " er í strengnum " + s);
            }
            else
            {
                Console.WriteLine("Textinn " + l + " er ekki í strengnum " + s);
            }
        }

        static void D14()
        {
            Console.Write("Póstnúmer: ");
            int tala = Console.ReadLine().ToInt();

            int tsumma = tala.ToString().ToCharArray().Sum(i => Convert.ToInt32(i.ToString()));

            int t = 0;

            while ((tsumma + t) % 10 != 0)
            {
                t++;
            }

            Console.WriteLine("Vartalan er " + t);
        }

        static void D13()
        {
            Regex rx = new Regex(@"^\(-?[0-9]+,-?[0-9]+\)\(-?[0-9]+,-?[0-9]+\)\(-?[0-9]+,-?[0-9]+\)\(-?[0-9]+,-?[0-9]+\)$");

            Console.WriteLine("Sláið inn textastreng sem inniheldur hnit hornpunkta:");
            string s = Console.ReadLine();
            if (rx.IsMatch(s))
            {
                Console.WriteLine("þessi textastrengur fylgir reglum.");
            }
            else
            {
                Console.WriteLine("þessi textastrengur fylgir ekki reglum.");
            }
        }

        static void D12()
        {
            Console.Write("Línufjöldi: ");
            int l = Console.ReadLine().ToInt();
            Console.Write("Dálkafjöldi: ");
            int d = Console.ReadLine().ToInt();
            Console.WriteLine();

            for (int nl = 1; nl <= l * 2 + 1; nl++)
            {
                for (int nd = 1; nd <= d * 3 + 1; nd++)
                {
                    if (nl % 2 == 0)
                    {
                        if ((nd % 3) % 2 == 0 || (nd % 3) == 0)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("|");
                        }
                    }
                    else
                    {
                        if ((nd % 3) % 2 == 0 || (nd % 3) == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write("X");
                        }
                    }
                }

                Console.WriteLine();
            }
        }

        static void D11()
        {
            Console.Write("klukkustund: ");
            int klst = Console.ReadLine().ToInt();
            Console.Write("mínúta: ");
            int min = Console.ReadLine().ToInt();
            Console.Write("sekúnta: ");
            int sek = Console.ReadLine().ToInt();

            while (sek > 59)
            {
                min++;
                sek -= 60;
            }

            while (min > 59)
            {
                klst++;
                min -= 60;
            }

            while (klst > 23)
            {
                klst -= 24;
            }

            Console.WriteLine(klst + ":" + NullEfMinnaEnTiu(min) + ":" + NullEfMinnaEnTiu(sek));
        }

        static string NullEfMinnaEnTiu(int i)
        {
            if (i < 10) return "0" + i;
            else return i.ToString();
        }

        static void D10()
        {
            string file = null;

            do
            {
                if (file != null) Console.WriteLine("Skráin " + file + " er ekki til, sláðu inn nafn á skrá sem er til.");
                Console.Write("Skrá sem inniheldur texta: ");
                file = Console.ReadLine();
            } while (file == "$" || !File.Exists(file));

            if (file != "$" && File.Exists(file))
            {
                //Console.WriteLine("Skráin inniheldur " + File.ReadAllText(file, Encoding.Default).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(s => s.ToCharArray().All(c => Char.IsLetterOrDigit(c) || new char[] { 'é', 'ý', 'ú', 'í', 'ó', 'ð', 'ö', 'á', 'æ', 'þ' }.Contains(c.ToLower()))).Count() + " orð.");

                StreamReader sr = new StreamReader(file, Encoding.Default);
                string innihald = sr.ReadToEnd().Replace("\r\n", " ").Replace("\n", " ");
                sr.Close();

                while (innihald.Contains("  "))
                {
                    innihald = innihald.Replace("  ", " ");
                }

                string[] ord = innihald.Split(' ');
                int morgord = 0;

                foreach (string o in ord)
                {
                    bool erOrd = false;
                    for (int i = 0; i < o.Length; i++)
                    {
                        if (Char.IsLetterOrDigit(o[i]) || new string[] { "á", "í", "ó", "ú", "ý", "é", "ð", "ö", "æ", "þ" }.Contains(o[i].ToString().ToLower()))
                        {
                            erOrd = true;
                        }
                    }

                    if (erOrd)
                    {
                        morgord++;
                    }
                }

                Console.WriteLine("Skráin inniheldur " + morgord + " orð.");
            }
        }

        static void D9()
        {
            Console.Write("Texti: ");
            string s = Console.ReadLine();

            s = s.ReplaceAll("  ", " ").Trim().ToLower();
            string n = "";

            foreach (string o in s.Split(' '))
            {
                for (int i = 0; i < o.Length; i++)
                {
                    if (i == 0 && (n.EndsWith(". ") || n == ""))
                    {
                        n += o[i].ToUpper();
                    }
                    else
                    {
                        n += o[i];
                    }
                }

                n += ' ';
            }

            Console.WriteLine(n);
        }

        static void D8()
        {
            Console.Write("Upphafsupphæð: ");
            int u = Console.ReadLine().ToInt();
            Console.Write("Árleg viðbót: ");
            int v = Console.ReadLine().ToInt();
            Console.Write("Vextir í prósentum: ");
            int p = Console.ReadLine().ToInt();
            Console.Write("Fjöldi ára: ");
            int a = Console.ReadLine().ToInt();

            for (int i = 0; i < a; i++)
            {
                u += u / p;
                if (i > 0) u += v;
            }

            Console.WriteLine("Lokaupphæð er " + u);
        }

        static void D7()
        {
            Random r = new Random();

            int s = 10000000;
            var q = from n in 1.To(s)//.AsParallel()
                    let l = new List<int> { r.Next(1, 7), r.Next(1, 7), r.Next(1, 7), r.Next(1, 7), r.Next(1, 7) }
                    where IsHouse(l)
                    select 1;

            Console.WriteLine((decimal)q.Sum() / (decimal)s);
        }

        static bool IsHouse(List<int> l)
        {
            l.Sort();

            if ((l[0] == l[1] && l[2] == l[3] && l[3] == l[4]) || (l[0] == l[1] && l[1] == l[2] && l[3] == l[4]))
            {
                return !(l[0] == l[1] && l[1] == l[2] && l[2] == l[3] && l[3] == l[4]);
            }
            else return false;
        }

        static void D6()
        {
            Console.Write("Hversu margar stjörnur í hlið þríhyrningsins? ");
            int l = Console.ReadLine().ToInt();

            Console.WriteLine();
            Console.WriteLine(DrawObjects.Triangle(l, "*", " ", DrawObjects.TriangleType.TopRight));
        }

        static void D5()
        {
            Console.Write("Hver er talan? ");
            int tala = Console.ReadLine().ToInt();

            string mal = TalaIMal(tala, false).ToLower().Trim().ReplaceAll("  ", " ");
            Console.WriteLine(mal);
        }

        static string[] malEiningar = new string[] { "núll", "einn", "tveir", "þrír", "fjórir", "fimm", "sex", "sjö", "átta", "níu", "tíu", "ellefu", "tólf", "þrettán", "fjórtán", "fimmtán", "sekstán", "sautján", "átján", "nítján" };
        static string[] malTugir = new string[] { "", "tíu", "tuttugu", "þrjátíu", "fjörtíu", "fimmtíu", "sextíu", "sjötíu", "áttatíu", "nítíu", "hundrað" };
        static string[] malHundrud = new string[] { "", "eitt", "tvö", "þrjú", "fjögur", "fimm", "sex", "sjö", "átta", "níu", "hundruð" };

        static string TalaIMal(int tala, bool h)
        {
            int tugir, ein, hundrud, afg;
            if ((tala >= 0 && tala <= 19 && !h) || (tala >= 0 && tala <= 9 && h))
            {
                return h ? malHundrud[tala] : malEiningar[tala];
            }

            if (tala < 100)
            {
                tugir = tala / 10;
                ein = tala - (tugir * 10);

                if (ein == 0)
                {
                    return malTugir[tugir];
                }
                else
                {
                    return malTugir[tugir] + " og " + malEiningar[ein];
                }
            }

            hundrud = tala / 100;
            afg = tala % 100;
            tugir = afg / 10;
            ein = afg % 10;

            string hu = hundrud == 1 ? TalaIMal(hundrud, true) + " hundrað " : TalaIMal(hundrud, true) + " hundruð ";

            if (tugir == 0 && ein == 0)
            {
                return hu;
            }

            if (tugir <= 1)
            {
                return hu + " og " + malEiningar[ein + (tugir * 10)];
            }

            return hu + TalaIMal(ein + (tugir * 10), false);
        }

        static void D4()
        {
            Console.Write("Fyrsta tala? ");
            int f = Console.ReadLine().ToInt();

            Console.Write("Síðasta tala? ");
            int s = Console.ReadLine().ToInt();

            Console.Write("Veldi ");
            int v = Console.ReadLine().ToInt();

            Console.WriteLine("Niðurstaða: " + f.To(s).Sum(i => Math.Pow(i, v)));
        }

        static void D3()
        {
            Console.Write("Tala: ");
            int t = Console.ReadLine().ToInt();

            int c = t / 50;
            t %= 50;

            int x = t / 10;
            t %= 10;

            int s = t;

            Console.WriteLine(new String('*', s) + new String('X', x) + new String('C', c));
        }

        static void D2()
        {
            string s = File.ReadAllText("D2.txt");

            int n = 1;
            s.Split(' ').Select(i => i.ToInt()).ForEach(i =>
            {
                Console.Write(n++ + ": " + i + "\t");

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            });
        }

        static void D1B()
        {
            Console.Write("Nafn: ");
            string s = Console.ReadLine();

            Console.WriteLine(String.Join(" ", s.ToCharArray()));
        }

        static void D1()
        {
            Console.Write("Nafn: ");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i]);
                Console.Write(" ");
            }
        }
    }
}