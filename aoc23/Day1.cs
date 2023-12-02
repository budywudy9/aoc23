using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc23
{
    public static class Day1
    {
        // song of the day:
        // Kimi no Taion covered by RENJI/URU ft. Rouon Aro
        // original by Kuwagata-P ft. Hatsune Miku
        // romanisation of lyrics taken from https://vocaloidlyrics.fandom.com/wiki/君の体温_(Kimi_no_Taion)

        public static int azayakaNiHikaruSonoIroNi()
        {
            string[] torawareteAyumiOTometa = kokoNiItaKotoKimiNoTaion("input.txt");
            int[] nakushiteTadaSetsunakute = oimotometaNoWaMaboroshi(torawareteAyumiOTometa);
            return nakushiteTadaSetsunakute.Aggregate(0, (a, b) => a += b);
        }

        private static int[] oimotometaNoWaMaboroshi(string[] natsukashiiKimiNoKoeOKiitaYo)
        {
            List<int> imaWaMouHarukaTookuHibikuOto = new List<int>();

            
            char[] bokuraAiNanteYonda = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (string hanaGaSaiteTsukiGaMichite in natsukashiiKimiNoKoeOKiitaYo)
            {
                // p1
                /*
                * il.Add(Int32.Parse($"{s.ElementAt(s.IndexOfAny(nums))}{st.ElementAt(st.LastIndexOfAny(nums))}"));
                */

                // p2
                // this part was done at like 3am while tipsy
                // also after finishing work at midnight
                string mataKeshikiONurikaete = hanaGaSaiteTsukiGaMichite.Replace("one", "o1e")
                    .Replace("two", "t2o")
                    .Replace("three", "t3e")
                    .Replace("four", "f4r")
                    .Replace("five", "f5e")
                    .Replace("six", "s6x")
                    .Replace("seven", "s7n")
                    .Replace("eight", "e8t")
                    .Replace("nine", "n9e");
                imaWaMouHarukaTookuHibikuOto.Add(Int32.Parse($"{mataKeshikiONurikaete.First(Char.IsDigit)}{(mataKeshikiONurikaete.Last(Char.IsDigit))}"));
            }

            return imaWaMouHarukaTookuHibikuOto.ToArray();
        }

        private static string[] kokoNiItaKotoKimiNoTaion(string wasureteItsukaTsumetakuSoreDakeSa)
        {
            wasureteItsukaTsumetakuSoreDakeSa = "..\\" + wasureteItsukaTsumetakuSoreDakeSa;
            List<string> minaretaMachiOHitoriDeAruku = new List<string>();

            foreach (string kimiNoInaiBashoOSagashite in File.ReadLines(wasureteItsukaTsumetakuSoreDakeSa))
            {
                minaretaMachiOHitoriDeAruku.Add(kimiNoInaiBashoOSagashite);
            }

            return minaretaMachiOHitoriDeAruku.ToArray();
        }
    }
}
