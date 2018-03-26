using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    class Program {
        static void Main(string[] args) {
            List<string> messages = new List<string>();
            List<BaseKingdom> kingdoms = new List<BaseKingdom>();
            BaseKingdom space = new Kingdom("Space", "Gorilla", "Shan");
            kingdoms.Add(space);
            kingdoms.Add(new Kingdom("Land", "Panda", "Land Ruler"));
            kingdoms.Add(new Kingdom("Water", "Octopus", "Water Ruler"));
            kingdoms.Add(new Kingdom("Ice", "Mammoth", "Ice Ruler"));
            kingdoms.Add(new Kingdom("Air", "Owl", "Air Ruler"));
            kingdoms.Add(new Kingdom("Fire", "Dragon", "Fire Ruler"));
            Southeros southeros = new Southeros(kingdoms);

            Console.WriteLine("Who is the ruler of Southeros?");
            Console.WriteLine(southeros.GetRulingKingdom() == null ? "None" : "King " + southeros.GetRulingKingdom().GetRuler());
            Console.WriteLine("Allies of ruler?");
            Console.WriteLine(southeros.GetRulingKingdom() == null ? "None" : (southeros.GetRulingKingdom().GetAllies() == null ? "None" :string.Join(",", southeros.GetRulingKingdom().GetAllies().Select(k => k.GetName()))));

            while(southeros.GetRulingKingdom() == null)
            {
                Console.WriteLine($"Input messages to kingdoms from King {space.GetRuler()}");
                messages.Add(Console.ReadLine());
                messages.Add(Console.ReadLine());
                messages.Add(Console.ReadLine());
                messages.Add(Console.ReadLine());
                messages.Add(Console.ReadLine());
                space.InvokeAllegiance(messages);
            }

            Console.WriteLine("Who is the ruler of Southeros?");
            Console.WriteLine(southeros.GetRulingKingdom() == null ? "None" : "King " + southeros.GetRulingKingdom().GetRuler());
            Console.WriteLine("Allies of ruler?");
            Console.WriteLine(southeros.GetRulingKingdom().GetAllies() == null ? "None" : string.Join(",", southeros.GetRulingKingdom().GetAllies().Select(k => k.GetName())));

            Console.Read();
        }
    }
}
