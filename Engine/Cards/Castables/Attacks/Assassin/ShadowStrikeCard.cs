using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class ShadowStrikeCard : Card
{
    public override int PipCost => Card.LEVEL_ONE_PROFESSION_PIP_COST;
    public override object Type => AssassinAttackEnum.SHADOW_STRIKE;

    public const int ATTACK_DAMAGE = 350;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, ATTACK_DAMAGE);
        player.AddBlade(BladeEnum.MINI_BLADE);
    }
}