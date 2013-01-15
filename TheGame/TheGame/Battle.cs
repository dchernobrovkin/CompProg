using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;


namespace TheGame
{
     class Battle
    {
        public void Log (Character Char1, Character Char2)
        {                      
            //if (Char1.Evasion < luck)
            //{
            //Char1.CurHealthPoints = 1; //Char1.CurHealthPoints - Char1.Attack * (uint)Char2.Damage_Reduction;
            //}
            
            //if (Char2.Evasion < luck)
            //{
              
            //}
            
            //return Char2.CurHealthPoints;
        }
        public void OneRound(Character Char1, Character Char2)
        {
            var rand = new Random();
            var luck1 = rand.Next(48);
            var luck2 = rand.Next(48);
            
            if (Char1.Evasion < luck1)
            {
                Char1.CalcHealthAfterDmg(Char2.Attack, Char1.Damage_Reduction);
            }

            if (Char2.Evasion < luck2)
            {
                Char2.CalcHealthAfterDmg(Char1.Attack, Char2.Damage_Reduction);
            }       
        }
    }
}
