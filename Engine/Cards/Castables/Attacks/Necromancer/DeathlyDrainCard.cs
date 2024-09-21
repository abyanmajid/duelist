using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class DeathlyDrainCard : Card
{
    public override int PipCost => Card.LEVEL_FOUR_PROFESSION_PIP_COST;
    public override object Type => NecromancerAttackEnum.DEATHLY_DRAIN;

    public const int OUTGOING_DAMAGE = 720;
    public const int INCOMING_HEAL = 300;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddHealth(INCOMING_HEAL);
        player.SendDebuff(enemy, DebuffEnum.WEAKNESS);
        player.SendDebuff(enemy, DebuffEnum.WEAKNESS);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
    }
}