using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class ShadowGraspCard : Card
{
    public override int PipCost => Card.LEVEL_THREE_PROFESSION_PIP_COST;
    public override object Type => NecromancerAttackEnum.SHADOW_GRASP;

    public const int OUTGOING_DAMAGE = 520;
    public const int INCOMING_HEAL = 210;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddHealth(INCOMING_HEAL);
        player.SendDebuff(enemy, DebuffEnum.WEAKNESS);
        player.SendDebuff(enemy, DebuffEnum.CURSE);
    }
}