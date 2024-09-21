using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class FortressSlamCard : Card
{
    public override int PipCost => Card.LEVEL_THREE_PROFESSION_PIP_COST;
    public override object Type => GuardianAttackEnum.FORTRESS_SLAM;

    public const int OUTGOING_DAMAGE = 460;

    public override void Cast(Player player, Player enemy)
    {
        player.SendDamage(enemy, OUTGOING_DAMAGE);
        player.AddShield(ShieldEnum.REGULAR_SHIELD);
        player.AddBlade(BladeEnum.MINI_BLADE);
        player.SendStun(enemy, 1);
    }
}