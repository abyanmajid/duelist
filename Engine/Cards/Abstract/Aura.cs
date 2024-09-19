using Duelist.Engine.Players;

namespace Duelist.Engine.Cards.Abstract;

public abstract class Aura : Buff
{
    public int LastingRounds { get; set; }

    public Aura(string name, int pipCost, double percentageIncrease, int lastingRounds) : base(name, pipCost, percentageIncrease)
    {
        if (lastingRounds <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(percentageIncrease), "Lasting rounds must be greater than 0.");
        }

        this.LastingRounds = lastingRounds;
    }

    public override abstract void Play(Player player, Player enemy);
}