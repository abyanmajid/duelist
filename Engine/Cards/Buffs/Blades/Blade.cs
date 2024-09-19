using Duelist.Engine.Players;
using Duelist.Engine.Cards.Abstract;

namespace Duelist.Engine.Cards.Buffs;

public class Blade : Card
{
    private double attackIncrease { get; set; }

    public Blade(string name, int pipCost, double attackIncrease) : base(name, pipCost)
    {
        if (attackIncrease <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(attackIncrease), "Attack percentage increase must be greater than 0.");
        }

        this.attackIncrease = attackIncrease;
    }

    public override void Play(Player player, Player enemy)
    {
    }
}