using Duelist.Engine.Players;

namespace Duelist.Engine.Cards.Abstract;

public abstract class Debuff : Card
{
    public double PercentageDecrease { get; set; }

    public Debuff(string name, int pipCost, double percentageDecrease) : base(name, pipCost)
    {
        if (percentageDecrease >= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(percentageDecrease), "Percentage increase must be greater than 0.");
        }

        this.PercentageDecrease = percentageDecrease;
    }

    public override abstract void Play(Player player, Player enemy);
}