using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class BoneSpikeCard : Card
{
    public override int PipCost => Card.LEVEL_TWO_PROFESSION_PIP_COST;
    public override object Type => NecromancerAttackEnum.BONE_SPIKE;

    public const int OUTGOING_DAMAGE = 370;
    public const int INCOMING_HEAL = 140;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddHealth(INCOMING_HEAL);
        player.SendDebuff(enemy, DebuffEnum.WEAKNESS);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
    }
}