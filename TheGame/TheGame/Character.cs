using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheGame
{
    class Character
    {
        public string Name { get; set; }
        
        public uint Attack { get; set; }
        public uint Endurance { get; set; }
        public uint Constitution { get; set; }
        public uint Dexterity { get; set; }

        public uint Level { get; set; }
        public uint Experience { get; set; }

        // This properties are computed from the values of Attack, Defense, etc
        // This is suboptimal, but who cares

        public uint HealthPoints
        {
            get
            {
                return Constitution * 10;
            }
            private set { }
        }
    }
}
