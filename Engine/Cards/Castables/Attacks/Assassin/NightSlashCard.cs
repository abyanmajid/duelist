using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class NightSlashCard : Card
{
    public override int PipCost => Card.LEVEL_THREE_PROFESSION_PIP_COST;
    public override object Type => AssassinAttackEnum.NIGHT_SLASH;

    public const int OUTGOING_DAMAGE = 700;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.MINI_BLADE);
        player.AddShield(ShieldEnum.REGULAR_SHIELD);
    }
}