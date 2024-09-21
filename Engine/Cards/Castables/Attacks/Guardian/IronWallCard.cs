using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class IronWallCard : Card
{
    public override int PipCost => Card.LEVEL_FOUR_PROFESSION_PIP_COST;
    public override object Type => GuardianAttackEnum.IRON_WALL;

    public const int OUTGOING_DAMAGE = 640;

    public override void Cast(Player player, Player enemy)
    {
        player.SendDamage(enemy, OUTGOING_DAMAGE);
        player.AddShield(ShieldEnum.REGULAR_SHIELD);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
        player.SendDebuff(enemy, DebuffEnum.CURSE);
    }
}