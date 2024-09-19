using Duelist.Engine.Players;

namespace Duelist.Engine.Cards.Abstract;

public abstract class Buff : Card
{
    public double PercentageIncrease { get; set; }

    public Buff(string name, int pipCost, double percentageIncrease) : base(name, pipCost)
    {
        if (percentageIncrease <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(percentageIncrease), "Percentage increase must be greater than 0.");
        }

        this.PercentageIncrease = percentageIncrease;
    }

    public override abstract void Play(Player player, Player enemy);
}
