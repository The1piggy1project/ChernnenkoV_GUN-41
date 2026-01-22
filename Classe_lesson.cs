using System;

namespace Classe_lesson
{
    public class Unit
    {

        private float _health;


        public string Name { get; }


        public float Health => _health;


        public int Damage { get; }


        public float Armor { get; }


        public Unit() : this("Unknown Unit")
        {
        }


        public Unit(string name)
        {
            Name = name;
            _health = 100f;
            Damage = 5;
            Armor = 0.6f;
        }


        public float GetRealHealth()
        {
            return _health * (1f + Armor);
        }


        public bool SetDamage(float value)
        {
            _health -= value * Armor;
            return _health <= 0f;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit("Warrior");

            Console.WriteLine("Name: " + unit.Name);
            Console.WriteLine("Health: " + unit.Health);
            Console.WriteLine("Real Health: " + unit.GetRealHealth());

            Console.WriteLine("\nUnit takes 50 damage...");
            bool isDead = unit.SetDamage(50f);

            Console.WriteLine("Health after damage: " + unit.Health);
            Console.WriteLine("Is Dead: " + isDead);

            Console.ReadLine();
        }
    }
}