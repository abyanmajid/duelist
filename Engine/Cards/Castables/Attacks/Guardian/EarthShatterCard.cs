using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class EarthShatterCard : Card
{
    public override int PipCost => Card.LEVEL_FIVE_PROFESSION_PIP_COST;
    public override object Type => GuardianAttackEnum.EARTH_SHATTER;

    public const int OUTGOING_DAMAGE = 820;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.SetSpecialEffect(SpecialEffectEnum.SIEGE);
    }
}