using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class ShieldBashCard : Card
{
    public override int PipCost => Card.LEVEL_ONE_PROFESSION_PIP_COST;
    public override object Type => GuardianAttackEnum.SHIELD_BASH;

    public const int OUTGOING_DAMAGE = 260;

    public override void Cast(Player player, Player enemy)
    {
        player.SendDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
    }
}