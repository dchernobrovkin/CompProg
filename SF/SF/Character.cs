using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SF
{
    class Character
    {


        public string Name { get; set; }

        public int Strength { get; set; }
        public int Endurance { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        private int _HealthPoints;

        //public uint Level { get; set; }
        //public uint Experience { get; set; }

        // This properties are computed from the values of Attack, Defense, etc
        // This is suboptimal, but who cares

        public int MaxHealthPoints
        {
            get
            {

                return Constitution * 10;
            }
            // set 
            //{
            //HealthPoints = value;
            //= HealthPoints;
            //value = value - dmg * (uint)red;
            //
        }

        public Character()
        {
            _HealthPoints = 0;
        }

        public int CurHealthPoints
        {
            get
            {
                return _HealthPoints;
            }
            set
            {
                _HealthPoints = value;
                //= HealthPoints;
                //value = value - dmg * (uint)red;
            }
        }



        /*public uint TempHP
        {
            get { return TempHP; }
            set { TempHP = value; }
        }*/


        public static double CalcHealthAfterDmg(double dmg, double red, double CurHealthPoints) 
        {
            var CurHP = CurHealthPoints;
            CurHP = CurHP - (dmg - red);
            CurHealthPoints = CurHP;
            return CurHealthPoints;
            //return CurHP;
            //TempHP = TempHP - dmg * (uint)red;
        }

        /*public uint CH
        {
            get { return TempHP; }
            set { }
        }*/
        public int Attack
        {
            get
            {
                return Strength * 2;
            }
            private set { }
        }

        public double Damage_Reduction
        {
            get
            {
                return Endurance * 0.55;
            }
            private set { }
        }

        public double Evasion
        {
            get
            {
                return Dexterity * 0.95;
            }
            private set { }

        }


    }
}
