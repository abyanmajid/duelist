using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class FatefulPunishmentCard : Card
{
    public override int PipCost => Card.LEVEL_ONE_PROFESSION_PIP_COST;
    public override object Type => AssassinAttackEnum.FATEFUL_PUNISHMENT;

    public const int OUTGOING_DAMAGE = 650;
    public const int INCOMING_DAMAGE = 450;

    public override void Cast(Player player, Player enemy)
    {
        bool shouldAttackEnemy = new Random().Next(0, 100) < 70;

        if (shouldAttackEnemy)
        {
            player.InflictDamage(enemy, OUTGOING_DAMAGE);
        }
        else
        {
            player.InflictDamage(player, INCOMING_DAMAGE);
        }
    }
}