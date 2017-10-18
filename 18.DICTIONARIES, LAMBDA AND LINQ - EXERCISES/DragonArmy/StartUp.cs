using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();
                string type = line[0];
                string name = line[1];
                int dmg = line[2] != "null" ? int.Parse(line[2]) : 45;
                int hp = line[3] != "null" ? int.Parse(line[3]) : 250;
                int armor = line[4] != "null" ? int.Parse(line[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                }

                if (!dragons[type].Where(x => x.Name == name).Any())
                {
                    dragons[type].Add(new Dragon(dmg, hp, armor, name));
                }

                dragons[type].Where(x => x.Name == name).First().Armor = armor;
                dragons[type].Where(x => x.Name == name).First().Damage = dmg;
                dragons[type].Where(x => x.Name == name).First().Health = hp;


            }

            foreach (var type in dragons)
            {
                double dmgAv = (double)type.Value.Select(x => x.Damage).Sum() / (double)type.Value.Count();
                double hpAv = (double)type.Value.Select(x => x.Health).Sum() / (double)type.Value.Count();
                double armAv = (double)type.Value.Select(x => x.Armor).Sum() / (double)type.Value.Count();

                Console.WriteLine($"{type.Key}::({dmgAv:f2}/{hpAv:f2}/{armAv:f2})");
                foreach (var dragon in type.Value.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public int Damage = 45;

        public int Health = 250;

        public int Armor = 10;

        public string Name { get; set; }

        public Dragon(int dmg, int hp, int armor, string name)
        {
            this.Damage = dmg;
            this.Health = hp;
            this.Armor = armor;
            this.Name = name;
        }
    }
}
