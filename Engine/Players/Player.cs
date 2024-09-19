using Duelist.Engine.Cards.Abstract;
using Duelist.Engine.Cards.Buffs;

namespace Duelist.Engine.Players;

public class Player
{
    public string Name { get; private set; } = "Guest";
    public Profession Profession { get; private set; }
    public int Pips { get; private set; } = 1;
    public List<Shield> Shields { get; private set; } = new List<Shield>();
    public List<Blade> Blades { get; private set; } = new List<Blade>();
    public Aura? aura { get; set; } = null;

    public List<Card> Deck { get; private set; } = new List<Card>();

    public Player(string name, ProfessionType professionType)
    {
        this.Name = name;
        this.Profession = Profession.SetProfession(professionType);
    }
}

