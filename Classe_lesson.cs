using System;

namespace Classe_lesson
{
    public struct Interval
    {
        private static Random _random = new Random();

        public float Min { get; }
        public float Max { get; }

        public Interval(int minValue, int maxValue)
        {
            bool incorrect = false;

            if (minValue < 0)
            {
                minValue = 0;
                incorrect = true;
            }

            if (maxValue < 0)
            {
                maxValue = 0;
                incorrect = true;
            }

            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
                incorrect = true;
            }

            if (minValue == maxValue)
            {
                maxValue += 10;
                incorrect = true;
            }

            if (incorrect)
            {
                Console.WriteLine("Некорректные входные данные Interval");
            }

            Min = minValue;
            Max = maxValue;
        }

        public float Get()
        {
            return (float)(_random.NextDouble() * (Max - Min) + Min);
        }
    }

  
    public class Weapon
    {
        public string Name { get; }
        public Interval Damage { get; }

        public Weapon(string name, int minDamage, int maxDamage)
        {
            Name = name;
            Damage = new Interval(minDamage, maxDamage);
        }

        public override string ToString()
        {
            return $"{Name} (Damage: {Damage.Min}-{Damage.Max})";
        }
    }

    
    public class Unit
    {
        private float _health;

        public string Name { get; }
        public float Health => _health;

       
        public Interval Damage { get; }

        public float Armor { get; }

      
        public Unit() : this("Unknown Unit", 0, 10)
        {
        }

    
        public Unit(string name) : this(name, 0, 10)
        {
        }

       
        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _health = 100f;
            Armor = 0.6f;
            Damage = new Interval(minDamage, maxDamage);
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

        public override string ToString()
        {
            return $"{Name} (HP: {_health}, Damage: {Damage.Min}-{Damage.Max})";
        }
    }

   
    public struct Room
    {
        public Unit Unit;
        public Weapon Weapon;

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }

   
    public class Dungeon
    {
        private Room[] _rooms;

        public Dungeon()
        {
            _rooms = new Room[]
            {
                new Room(
                    new Unit("Goblin", 1, 5),
                    new Weapon("Dagger", 2, 6)
                ),
                new Room(
                    new Unit("Skeleton", 3, 8),
                    new Weapon("Sword", 5, 12)
                ),
                new Room(
                    new Unit("Orc", 6, 15),
                    new Weapon("Axe", 10, 20)
                )
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                var room = _rooms[i];

                Console.WriteLine("Unit of room: " + room.Unit);
                Console.WriteLine("Weapon of room: " + room.Weapon);
                Console.WriteLine("—");
            }
        }
    }

   
    internal class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();

            Console.ReadLine();
        }
    }
}
