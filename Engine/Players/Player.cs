using Duelist.Engine.Cards.Buffs;

namespace Duelist.Engine.Players;

public class Player
{
    private string name { get; set; } = "Guest";
    private int health { get; set; }
    private int maxHealth { get; set; }
    private Profession profession { get; set; }
    private int pips { get; set; } = 2;
    private List<Shield> shields { get; set; } = new List<Shield>();
    private List<Blade> blades { get; set; } = new List<Blade>();
    private Aura aura { get; set; }

    private GlobalEffect globalEffect { get; set; }

    private List<Card> deck;
}

