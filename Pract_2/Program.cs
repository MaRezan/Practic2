using System;
using System.Linq;


namespace Pract_2
{
    class Program
    {
        public static string Translit(string s)
        {
            string[] rus = {"А","Б","В","Г","Д","Е","Ё","Ж", "З","И","Й","К","Л","М", "Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы","Ь",
          "Э","Ю", "Я" ,"а","б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю","я"};

            string[] eng = {"A","B","V","G","D","E","E","ZH","Z","I","Y","K","L","M","N",
          "O","P","R","S","T","U","F","KH","TS","CH","SH","SHCH","9","Y","",
          "E","YU","YA",   "a","b","v","g","d","e","e","zh","z","i","y","k","l","m","n",
          "o","p","r","s","t","u","f","kh","ts","ch","sh","shch","9","y","",
          "e","yu","ya"};

            string ret = "";
            for (int j = 0; j < s.Length; j++)
                for (int i = 0; i < rus.Length; i++)
                    if (s.Substring(j, 1) == rus[i]) ret += eng[i];

            return ret;
        }
        public static string Translit2(string s)
        {
            string[] rus = {"А","Б","В","Г","Д","Е","Ё","Ж", "З","И","Й","К","Л","М", "Н",
          "О","П","Р","С","Т","У","Ф","Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы","Ь",
          "Э","Ю", "Я" ,"а","б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю","я"};

            string[] eng = {"A","B","V","G","D","E","E","ZH","Z","I","Y","K","L","M","N",
          "O","P","R","S","T","U","F","KH","TS","CH","SH","SHCH","9","Y","",
          "E","YU","YA",   "a","b","v","g","d","e","e","zh","z","i","y","k","l","m","n",
          "o","p","r","s","t","u","f","kh","ts","ch","sh","shch","9","y","",
          "e","yu","ya"};

            string ret = "";
            for (int j = 0; j < s.Length; j++)
                for (int i = 0; i < rus.Length; i++)
                    if (s.Substring(j, 1) == eng[i]) ret += rus[i];

            return ret;
        }
        static void Main(string[] args)
        {
            ////Task_1
            //string str = Console.ReadLine();
            //int sum = str.Split(' ')[0].Count(c => char.ToLower(c) == 'f');
            //Console.WriteLine("");
            //if (sum==1)
            //{
            //    Console.WriteLine("-1");
            //}
            //else if (sum == 0)
            //{
            //    Console.WriteLine("-2");
            //}
            //else
            //{
            //    Console.WriteLine("В слове несколько букв f");
            //}

            ////Task_2
            //string s=Console.ReadLine();
            //Console.WriteLine(Translit(s));
            //Console.WriteLine(Translit2(s));

            ////Task_3
            //string a =Console.ReadLine();
            //char H = 'H';
            //string Hahah = "";
            //int fir = a.IndexOf("h");
            //int sec = a.LastIndexOf("h");
            //char[] a1 =a.ToCharArray();

            //for (int i = 0; i < a1.Length; i++)
            //{
            //    if (i != fir && i != sec)
            //    {
            //        if (a1[i].Equals('h'))
            //        {
            //            a1[i] = 'H';
            //        }

            //    }
            //    Hahah += a1[i];
            //}
            //Console.WriteLine(Hahah);
            
            

            
           




        }
       





        }
    }


