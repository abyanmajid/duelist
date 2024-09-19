namespace Duelist.Engine.Players
{
    public class Profession
    {
        public string Name { get; private set; }
        public int MaxHealth { get; private set; }
        public double Power { get; private set; }        // Percentage for attack increase
        public double Resistance { get; private set; }   // Percentage for decreasing enemy attacks
        public double Pierce { get; private set; }       // Percentage for decreasing enemy's resistance

        public Profession(string name, int maxHealth, double power, double resistance, double pierce)
        {
            Name = name;
            MaxHealth = maxHealth;
            Power = power;
            Resistance = resistance;
            Pierce = pierce;
        }

        public static Profession SetProfession(ProfessionEnum ProfessionEnum)
        {
            switch (ProfessionEnum)
            {
                case ProfessionEnum.Warrior:
                    return new Profession("Warrior", 2400, 40, 30, 10);
                case ProfessionEnum.Guardian:
                    return new Profession("Guardian", 3200, 20, 60, 5);
                case ProfessionEnum.Assassin:
                    return new Profession("Assassin", 1600, 75, 10, 30);
                case ProfessionEnum.Necromancer:
                    return new Profession("Necromancer", 2000, 30, 20, 5);
                default:
                    throw new ArgumentException("Invalid profession type");
            }
        }
    }
}
