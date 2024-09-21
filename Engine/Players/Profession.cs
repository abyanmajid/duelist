namespace Duelist.Engine.Players
{
    public class Profession
    {
        public string Name { get; private set; }
        public int MaxHealth { get; private set; }
        public double Power { get; set; }        // Percentage for attack increase
        public double Resistance { get; set; }   // Percentage for decreasing enemy attacks
        public double Pierce { get; set; }       // Percentage for decreasing enemy's resistance

        public Profession(string name, int maxHealth, double power, double resistance, double pierce)
        {
            Name = name;
            MaxHealth = maxHealth;
            Power = power;
            Resistance = resistance;
            Pierce = pierce;
        }

        public static Profession SetProfession(ProfessionEnum ProfessionType)
        {
            switch (ProfessionType)
            {
                case ProfessionEnum.WARRIOR:
                    return new Profession("Warrior", 3200, 40, 30, 10);
                case ProfessionEnum.GUARDIAN:
                    return new Profession("Guardian", 4500, 20, 60, 5);
                case ProfessionEnum.ASSASSIN:
                    return new Profession("Assassin", 2400, 75, 10, 30);
                case ProfessionEnum.NECROMANCER:
                    return new Profession("Necromancer", 3400, 30, 20, 5);
                default:
                    throw new ArgumentException("Invalid profession type");
            }
        }
    }
}
