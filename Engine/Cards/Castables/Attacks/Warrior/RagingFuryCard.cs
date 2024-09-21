using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class RagingFuryCard : Card
{
    public override int PipCost => Card.LEVEL_FOUR_PROFESSION_PIP_COST;
    public override object Type => WarriorAttackEnum.RAGING_FURY;

    public const int OUTGOING_DAMAGE = 870;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddShield(ShieldEnum.REGULAR_SHIELD);
        player.SendDebuff(enemy, DebuffEnum.CURSE);
        player.SendDebuff(enemy, DebuffEnum.WEAKNESS);
    }
}