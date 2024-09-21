using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class RapidSlashCard : Card
{
    public override int PipCost => Card.LEVEL_ONE_PROFESSION_PIP_COST;
    public override object Type => WarriorAttackEnum.RAPID_SLASH;

    public const int OUTGOING_DAMAGE = 285;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.AddBlade(BladeEnum.REGULAR_BLADE);
    }
}