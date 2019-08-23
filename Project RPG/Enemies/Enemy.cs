using System;
namespace Enemies

{
    public class Enemy
    {
        private int Level { get; }
        private int CurrentExperience;
        private int HitPoints;
        private int Strength;
        private int Intelligence;
        private int ExperienceGain;
        private int Wisdom;

        public Enemy() // Constructor
        {
            this.Level = 1;
            this.CurrentExperience = 0;
            this.HitPoints = 25;
            this.Strength = 5;
            this.Intelligence = 10;
            this.ExperienceGain = 5;
            this.Wisdom = 5;

        }

        public void GetHitPoints()
        {
            Console.WriteLine("Hitpoints: {0}", this.HitPoints);
        }



    }



}

