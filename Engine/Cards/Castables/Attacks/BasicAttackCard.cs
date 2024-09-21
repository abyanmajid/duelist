using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class BasicAttackCard : Card
{
    public const int OUTGOING_DAMAGE = 700;

    public override object Type { get; }
    public override int PipCost { get; }

    public BasicAttackCard(BasicAttackEnum basicAttackType)
    {
        switch (basicAttackType)
        {
            case BasicAttackEnum.BASIC_STRIKE:
                this.PipCost = 0;
                break;

            case BasicAttackEnum.MEGA_STRIKE:
                this.PipCost = 1;
                break;

            case BasicAttackEnum.EPIC_STRIKE:
                this.PipCost = 2;
                break;

            case BasicAttackEnum.SUPER_STRIKE:
                this.PipCost = 3;
                break;
        }

        this.Type = basicAttackType;
    }

    public override void Cast(Player player, Player enemy)
    {
        player.SendDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.MINI_BLADE);
        player.AddShield(ShieldEnum.REGULAR_SHIELD);
    }
}