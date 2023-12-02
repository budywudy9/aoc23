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

            // p1
            char[] bokuraAiNanteYonda = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            foreach (string hanaGaSaiteTsukiGaMichite in natsukashiiKimiNoKoeOKiitaYo)
            {
                string mataKeshikiONurikaete = hanaGaSaiteTsukiGaMichite.Replace("one", "1")
                    .Replace("two", "2")
                    .Replace("three", "3")
                    .Replace("four", "4")
                    .Replace("five", "5")
                    .Replace("six", "6")
                    .Replace("seven", "7")
                    .Replace("eight", "8")
                    .Replace("nine", "9");
                //il.Add(Int32.Parse($"{s.ElementAt(s.IndexOfAny(nums))}{st.ElementAt(st.LastIndexOfAny(nums))}"));
                imaWaMouHarukaTookuHibikuOto.Add(Int32.Parse($"{mataKeshikiONurikaete.First(Char.IsDigit)}{(mataKeshikiONurikaete.Last(Char.IsDigit))}"));
            }


            // p2
            // this part was done at like 3am while tipsy
            // also after finishing work at midnight

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
