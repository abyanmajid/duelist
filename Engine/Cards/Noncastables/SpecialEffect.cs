using Duelist.Engine.Players;

public class SpecialEffect
{
    public int LastingRounds { get; private set; } = 3;
    public SpecialEffectEnum SpecialEffectType { get; private set; }

    public SpecialEffect(SpecialEffectEnum specialEffectType)
    {
        this.SpecialEffectType = specialEffectType;
    }

    public void ApplyEffect(Player player, Player enemy)
    {
        switch (SpecialEffectType)
        {
            case SpecialEffectEnum.RAMPAGE:
                player.AddPip();

                foreach (ShieldEnum shield in enemy.Shields)
                {
                    enemy.Shields.Remove(shield);
                }

                break;

            case SpecialEffectEnum.SIEGE:
                player.AddShield(ShieldEnum.REGULAR_SHIELD);
                player.SendDebuff(enemy, DebuffEnum.CURSE);

                break;

            case SpecialEffectEnum.INVISIBLE:
                player.AddHealth(200);

                break;

            case SpecialEffectEnum.WRATH:
                player.SendDebuff(enemy, DebuffEnum.CURSE);
                enemy.TakeDamage((int)(enemy.Health * 0.05));

                break;

            default:
                throw new ArgumentException("Invalid special effect type.");
        }

        LastingRounds--;
    }
}