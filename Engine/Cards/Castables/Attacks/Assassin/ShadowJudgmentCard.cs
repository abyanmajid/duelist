using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class ShadowJudgmentCard : Card
{
    public override int PipCost => Card.LEVEL_FIVE_PROFESSION_PIP_COST;
    public override object Type => AssassinAttackEnum.SHADOW_JUDGMENT;

    public const int OUTGOING_DAMAGE = 1420;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.SetSpecialEffect(SpecialEffectEnum.INVISIBLE);
    }
}