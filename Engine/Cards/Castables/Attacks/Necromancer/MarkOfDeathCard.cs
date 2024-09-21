using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class MarkOfDeathCard : Card
{
    public override int PipCost => Card.LEVEL_FIVE_PROFESSION_PIP_COST;
    public override object Type => NecromancerAttackEnum.MARK_OF_DEATH;

    public const int OUTGOING_DAMAGE = 970;
    public const int INCOMING_HEAL = 600;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddHealth(INCOMING_HEAL);
        player.SetSpecialEffect(SpecialEffectEnum.WRATH);
    }
}