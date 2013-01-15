using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace SF
{
    class processing
    {

        public static string selectCHAR;
        public void Proc()
        {
            var z = SF.ThreadedServer.data + 1;
            var one = ThreadedServer.one;
            Console.WriteLine("Ops: " + one);
        }

        //public ObservableCollection<Character> CharacterList { get; private set; }

        public static double[] char1 = new double[4];
        public static double[] char2 = new double[4];

        public static void InitializeBattle(string param1, string param2)
        {
            var i1 = param1.IndexOf(";");
            var Attack1 = param1.Substring(0, i1);
            var CurHealthPoint1 = param1.Substring(Attack1.Length+1,param1.IndexOf(";",Attack1.Length+1)-2);
            var DamageReduction1 = param1.Substring(param1.IndexOf(";", Attack1.Length + CurHealthPoint1.Length + 1)+1,param1.IndexOf(";",Attack1.Length+CurHealthPoint1.Length));
            var Evasion1 = param1.Substring(param1.IndexOf(";",Attack1.Length + CurHealthPoint1.Length + DamageReduction1.Length)+1);
            char1[0] = double.Parse(Attack1);
            char1[1] = double.Parse(CurHealthPoint1);
            char1[2] = double.Parse(DamageReduction1);
            char1[3] = double.Parse(Evasion1);

            var i2 = param2.IndexOf(";");
            var Attack2 = param2.Substring(0, i1);
            var CurHealthPoint2 = param2.Substring(Attack2.Length + 1, param2.IndexOf(";", Attack2.Length + 1) - 2);
            var DamageReduction2 = param2.Substring(param2.IndexOf(";", Attack2.Length + CurHealthPoint2.Length + 1) + 1, param2.IndexOf(";", Attack2.Length + CurHealthPoint2.Length));
            var Evasion2 = param1.Substring(param2.IndexOf(";", Attack2.Length + CurHealthPoint2.Length + DamageReduction2.Length) + 1);
            char2[0] = double.Parse(Attack2);
            char2[1] = double.Parse(CurHealthPoint2);
            char2[2] = double.Parse(DamageReduction2);
            char2[3] = double.Parse(Evasion2);
           //Console.WriteLine("Att: " + Attack1 + " CurHP: " + CurHealthPoint1 + " DamRed: " + DamageReduction1 + " Evasion: " + Evasion1);
           // Console.WriteLine(DamageReduction);
        }

        public static void OneRound(string at1, string def1, string at2, string def2)
        {
            var rand = new Random();
            var luck1 = rand.Next(48);
            var luck2 = rand.Next(48);

            if (def1 != at2)
            {
                if (char1[3] < luck1)
                {

                    char1[1] = Character.CalcHealthAfterDmg(char2[0], char1[2], char1[1]);
                }
            }
            if (def2 != at1)
            {
                if (char2[3] < luck2)
                {
                    char2[1] = Character.CalcHealthAfterDmg(char1[0], char2[2], char2[1]);
                }
            }
            double[] SentHPofTWO = new double[2];
            SentHPofTWO[0] = char1[1];
            SentHPofTWO[1] = char2[1];
            
            Console.WriteLine("1: "+char1[1]+"| 2: "+char2[1]);
           
        }

        public static void SelectChar()
        {
            var z = new CharacterTable();
            
            selectCHAR = z.Name + "|" + z.Str + "|" + z.Endur + "|" + z.Const + "|" + z.Dex;
         }
    }
}
