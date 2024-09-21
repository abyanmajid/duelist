using Duelist.Engine.Players;

namespace Duelist.Engine.Cards;

public class BladeStormCard : Card
{
    public override int PipCost => Card.LEVEL_THREE_PROFESSION_PIP_COST;
    public override object Type => WarriorAttackEnum.BLADE_STORM;

    public const int OUTGOING_DAMAGE = 610;

    public override void Cast(Player player, Player enemy)
    {
        player.InflictDamage(enemy, OUTGOING_DAMAGE);
        player.SendDebuff(enemy, DebuffEnum.CURSE);
        player.SendDebuff(enemy, DebuffEnum.WEAKNESS);
        player.PopDebuff();
    }
}