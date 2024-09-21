using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class BasicAttackCard : Card
{
    private int outgoingDamage;

    public override object Type { get; }
    public override int PipCost { get; }

    public BasicAttackCard(BasicAttackEnum basicAttackType)
    {
        switch (basicAttackType)
        {
            case BasicAttackEnum.BASIC_STRIKE:
                this.PipCost = 0;
                this.outgoingDamage = 40;
                break;

            case BasicAttackEnum.MEGA_STRIKE:
                this.PipCost = 1;
                this.outgoingDamage = 90;
                break;

            case BasicAttackEnum.EPIC_STRIKE:
                this.PipCost = 2;
                this.outgoingDamage = 150;
                break;

            case BasicAttackEnum.SUPER_STRIKE:
                this.PipCost = 3;
                this.outgoingDamage = 220;
                break;
        }

        this.Type = basicAttackType;
    }

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, outgoingDamage);
    }
}