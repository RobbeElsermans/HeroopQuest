using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClasses
{
    enum HeldType
    {
        Barbaar, Dwerg, Elf, Tovenaar
    }
    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeldType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    AanvalDobbestenen = 3;
                    MaxIntelligentie = 2;
                    MaxLichaam = 8;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxLichaam = 7;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxLichaam = 6;
                    break;
                case HeldType.Tovenaar:
                    AanvalDobbestenen = 1;
                    MaxIntelligentie = 6;
                    MaxLichaam = 4;
                    break;
                default:
                    break;
            }
            HuidigInteligentie = MaxIntelligentie;
            HuidigLichaam = MaxLichaam;
        }

        public string Naam { get; set; }
        public int HuidigInteligentie { get; set; }
        public int HuidigLichaam { get; set; }

        public int MaxIntelligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public HeldType HeldType { get; private set; }
        public string Beschrijving { get; private set; }
        public int AanvalDobbestenen { get; private set; } = 2;
        public int Verdediging { get; private set; } = 2;
        public int LoopDobbelstenen { get; private set; } = 2;
    }
}
