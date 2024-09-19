using Duelist.Engine.Players;

namespace Duelist.Engine.Cards.Abstract;

public abstract class Card
{
    public string Name { get; set; }
    public int PipCost { get; set; }

    public Card(string name, int pipCost)
    {
        this.Name = name;
        this.PipCost = pipCost;
    }

    public abstract void Play(Player player, Player enemy);
}