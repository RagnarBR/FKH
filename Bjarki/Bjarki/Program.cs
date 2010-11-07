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

namespace Bjarki
{
    class Program
    {
        static void Main(string[] args)
        {
            D11();

            Console.ReadLine();
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