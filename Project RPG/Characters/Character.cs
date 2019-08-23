using System;

namespace Characters //Changed this to be the package
{
    public class Character
    {
        private int Level { get; }
        private int CurrentExperience;
        private int XpToLevel;
        private int HitPoints;
        private int MaxHitPoints;
        private int Strength;
        private int Intelligence;
        private int Wisdom;
        private int PhysDef;
        private int MagDef;

        public Character()
        {
            this.Level = 1;
            this.CurrentExperience = 0;
            this.XpToLevel = 100;
            this.HitPoints = 100;
            this.Strength = 10;
            this.Intelligence = 10;
            this.Wisdom = 10;
            this.PhysDef = 10;
            this.MagDef = 10;
        }

        public void PrintCharacter()
        {
            Console.WriteLine("Level: " + this.Level);
            Console.WriteLine("Current Experience: " + this.CurrentExperience);
            Console.WriteLine("Current HitPoints" + this.HitPoints);
        }
    }
}