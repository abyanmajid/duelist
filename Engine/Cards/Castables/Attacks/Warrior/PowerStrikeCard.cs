using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class PowerStrikeCard : Card
{
    public override int PipCost => Card.LEVEL_TWO_PROFESSION_PIP_COST;
    public override object Type => WarriorAttackEnum.POWER_STRIKE;

    public const int OUTGOING_DAMAGE = 415;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.PIERCE_BLADE);
        player.AddShield(ShieldEnum.REGULAR_SHIELD);
    }
}