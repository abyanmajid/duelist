namespace Duelist.Engine.Cards;

using Duelist.Engine.Players;

public abstract class Card
{
    public string Name { get; set; }
    public int PipCost { get; set; }

    public Card(string name, int pipCost)
    {
        Name = name;
        PipCost = pipCost;
    }

    public abstract void Play(Player player, Player enemy);
}