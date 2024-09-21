using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class SoulStrikeCard : Card
{
    public override int PipCost => Card.LEVEL_ONE_PROFESSION_PIP_COST;
    public override object Type => NecromancerAttackEnum.SOUL_STRIKE;

    public const int OUTGOING_DAMAGE = 270;
    public const int INCOMING_HEAL = 100;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddHealth(INCOMING_HEAL);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
    }
}