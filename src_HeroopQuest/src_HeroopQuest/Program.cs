using src_HeroopQuest.GameClasses;
using src_HeroopQuest.Properties;
using System;
using System.Collections.Generic;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Held held1 = new Held(HeldType.Barbaar, "Conan");
            Held held2 = new Held(HeldType.Tovenaar, "Bart");
            Held held3 = new Held(HeldType.Dwerg, "Floki");

            Console.WriteLine(held1.Naam);
            Console.WriteLine(held1.HeldType);
            Console.WriteLine(Resources.barbaarTekst);
            held1.ToonFiche();

            List<Held> deHelden = new List<Held>();
            deHelden.Add(held1);
            deHelden.Add(held2);
            deHelden.Insert(1, held3);

            Console.Clear();
            for (int i = 0; i < deHelden.Count; i++)
            {
                deHelden[i].ToonFiche();
            }
            //heldlijst creëren en als resultaat terug geven
        }
    }
}
