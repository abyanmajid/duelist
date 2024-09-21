using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class ShadowStrikeCard : Card
{
    public override int PipCost => Card.LEVEL_TWO_PROFESSION_PIP_COST;
    public override object Type => AssassinAttackEnum.SHADOW_STRIKE;

    public const int OUTGOING_DAMAGE = 460;

    public override void Cast(Player player, Player enemy)
    {
        player.SendDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
    }
}