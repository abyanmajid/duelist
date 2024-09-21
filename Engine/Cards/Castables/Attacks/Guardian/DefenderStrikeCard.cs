using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class DefenderStrikeCard : Card
{
    public override int PipCost => Card.LEVEL_TWO_PROFESSION_PIP_COST;
    public override object Type => GuardianAttackEnum.DEFENDER_STRIKE;

    public const int OUTGOING_DAMAGE = 340;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
        player.AddBlade(BladeEnum.PIERCE_BLADE);
    }
}