using Duelist.Engine.Players;
using Duelist.Engine.Cards.Abstract;

namespace Duelist.Engine.Cards.Buffs;

public class Shield : Card
{
    private double resistanceIncrease { get; set; }

    public Shield(string name, int pipCost, double resistanceIncrease) : base(name, pipCost)
    {
        if (resistanceIncrease <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(resistanceIncrease), "Resistance percentage increase must be greater than 0.");
        }

        this.resistanceIncrease = resistanceIncrease;
    }

    public override void Play(Player player, Player enemy)
    {
    }
}