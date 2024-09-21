using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class AssassinationCard : Card
{
    public override int PipCost => Card.LEVEL_FOUR_PROFESSION_PIP_COST;
    public override object Type => AssassinAttackEnum.ASSASSINATION;

    public const int OUTGOING_DAMAGE = 1020;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.SendStun(enemy, 1);
        player.AddBlade(BladeEnum.PIERCE_BLADE);
        player.AddBlade(BladeEnum.MINI_BLADE);
    }
}