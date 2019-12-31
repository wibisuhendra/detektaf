using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using FuzzyString;
using System.Threading.Tasks;


namespace spellcheckerBIndo
{
    class Mesin
    {
        private string[] kata;

        public string[] Kata { get => kata; set => kata = value; }

        public Mesin()
        {
            Kata = File.ReadAllLines("component/kamus.txt");
                       
        }

        public static string RemoveExcept(string value, bool alphas = false, bool numerics = false, bool dashes = false, bool underlines = false, bool spaces = false, bool periods = false)
        {
            if (string.IsNullOrWhiteSpace(value)) return value;
            if (new[] { alphas, numerics, dashes, underlines, spaces, periods }.All(x => x == false)) return value;

            var whitelistChars = new HashSet<char>(string.Concat(
                alphas ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "",
                numerics ? "01234567890" : "",
                dashes ? "-" : "",
                underlines ? "_" : "",
                periods ? "." : "",
                spaces ? " " : ""
            ).ToCharArray());

            var scrubbedValue = value.Aggregate(new StringBuilder(), (sb, @char) => {
                if (whitelistChars.Contains(@char)) sb.Append(@char);
                return sb;
            }).ToString();

            return scrubbedValue;
        }

        public string[] CekKata(string input)
        {
            string[] inputPerkata = input.Split(' ');

            for (int i = 0; i<inputPerkata.Length;i++)
            {
                int match = 0;
                foreach(string ini in Kata)
                {
                    if (inputPerkata[i].ToLower().Trim(new Char[] { '.', ',', '"', '\'' }).Equals(ini))
                    {
                        match = 1;
                    }
                    else
                    {
                        
                    }
                }
                if(match == 0)
                {
                    
                    inputPerkata[i] = "*" + inputPerkata[i] + "*";
                }
            }
            return inputPerkata;
        }

        public List<string> cekPerkata(string input)
        {
            string[] inputPerkata = input.Split(' ');
            List<string> tampungKata = new List<string>();

            int hitungSugestion = 0;
            

            for (int i = 0; i < inputPerkata.Length; i++)
            {
                hitungSugestion = 0;
                int match = 0;
                foreach (string ini in Kata)
                {
                    if (inputPerkata[i].ToLower().Trim(new Char[] { '.', ',', '"', '\'' }).Equals(ini))
                    {
                        match = 1;
                    }
                }
                if (match == 0)
                {
                    
                    string kataSementara = "*****" + inputPerkata[i] + " mungkin maksud anda ";
                    for (int j=0; j < kata.Length; j++)
                    {
                        if(FuzzyString.ComparisonMetrics.SorensenDiceDistance(inputPerkata[i].ToLower().Trim(
                            new Char[] { '.', ',', '"', '\'' }), kata[j]) < 0.35 )
                        {


                          
                            if (inputPerkata[i][0] == kata[j][0] && inputPerkata[i][1] == kata[j][1])
                            {
                                if (hitungSugestion == 0)
                                {
                                    kataSementara = kataSementara +  kata[j];
                                }
                                else
                                {
                                    kataSementara = kataSementara + "/" + kata[j];
                                }
                                
                                hitungSugestion++;
                            }
                            


                                                       
                        }
                        
                    }
                    tampungKata.Add(kataSementara);
                }
            }
            return tampungKata;
        }

        public void saveKamus(string kamus)
        {
            if (File.Exists("component/kamus.txt"))
            {
                File.Delete("component/kamus.txt");
            }

            using(StreamWriter sw = new StreamWriter("component/kamus.txt"))
            {

                sw.Write(kamus);

            }

            Kata = File.ReadAllLines("component/kamus.txt");
        }

        public void setdefaultKamus()
        {
            if (File.Exists("component/kamus.txt"))
            {
                File.Delete("component/kamus.txt");
            }

            string[] kamus = File.ReadAllLines("component/defaultkamus.txt");
            using (StreamWriter sw = new StreamWriter("component/kamus.txt"))
            {

                sw.Write(String.Join("\n",kamus));

            }
            Kata = File.ReadAllLines("component/kamus.txt");
        }
    }
}
