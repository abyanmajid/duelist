using System.Text.RegularExpressions;

namespace Duelist.Engine.Players;

public class Player
{
    // Constants
    const string VALID_PLAYER_NAME_REGEX = @"^[a-zA-Z0-9 ]+$";

    // Basic details
    public string Name { get; private set; } = "Guest";
    public Profession Profession { get; private set; }
    public int Health { get; private set; }
    public int Pips { get; private set; } = 1;

    // Individual Buffs
    public List<ShieldEnum> Shields { get; private set; } = new List<ShieldEnum>();
    public List<BladeEnum> Blades { get; private set; } = new List<BladeEnum>();
    public AuraEnum? Aura { get; set; } = null;

    // Individual Debuffs
    public List<DebuffEnum> Debuffs { get; private set; } = new List<DebuffEnum>();
    public int StunRounds { get; private set; } = 0;

    // Global Effect
    public GlobalEffectEnum? GlobalEffect { get; set; } = null;

    // Special Effect
    public SpecialEffectEnum? SpecialEffect { get; set; } = null;

    // Deck
    private List<object> SavedDeck = new List<object>();
    public List<object> Deck { get; private set; } = new List<object>();

    public Player(string? name, ProfessionEnum ProfessionEnum, List<object> deck)
    {
        this.Profession = Profession.SetProfession(ProfessionEnum);
        this.Health = this.Profession.MaxHealth;

        checkNameValidityAndSet(name);
        checkDeckValidityAndSet(deck);
    }

    private void checkNameValidityAndSet(string? name)
    {
        if (name == null || name == "")
        {
            this.Name = "Guest";
        }
        else
        {
            if (!Regex.IsMatch(name, VALID_PLAYER_NAME_REGEX))
            {
                throw new ArgumentException("Player name must ONLY comprise of characters that either letters, numbers, or spaces.");
            }

            if (Game._ProfanityFilter.ContainsProfanity(name.ToLower()))
            {
                throw new ArgumentException("Player name cannot contain profanity.");
            }

            this.Name = name;
        }
    }

    private void checkDeckValidityAndSet(List<object> deck)
    {
        if (deck.Count > 40)
        {
            throw new ArgumentException("The deck must contain at most 40 cards.");
        }

        this.SavedDeck = deck;
        this.Deck = this.SavedDeck;
    }

    public void IncreasePip()
    {
        this.Pips += 1;
    }

    public void ResetDeck()
    {
        this.Deck = this.SavedDeck;
    }

    public void InflictDamage(Player enemy, int attackDamage)
    {
        double damageWithPower = attackDamage * (1 + Profession.Power / 100.0);
        double effectiveResistance = Math.Max(0, enemy.Profession.Resistance - this.Profession.Pierce);
        double finalDamage = damageWithPower * (1 - effectiveResistance / 100.0);

        enemy.TakeDamage((int)Math.Round(finalDamage));
    }

    public void AddShield(ShieldEnum shield)
    {
        this.Shields.Add(shield);
    }

    public void Heal(int healthAddition)
    {
        this.Health = Math.Min(this.Profession.MaxHealth, this.Health + healthAddition);
    }

    public void AddBlade(BladeEnum blade)
    {
        this.Blades.Add(blade);
    }

    public void Stun(Player enemy, int stunRounds)
    {
        if (enemy.Shields.Contains(ShieldEnum.STUN_SHIELD))
        {
            enemy.Shields.Remove(ShieldEnum.STUN_SHIELD);
            return;
        }

        enemy.StunRounds = stunRounds;
    }

    public void SendDebuff(Player enemy, DebuffEnum debuff)
    {
        enemy.Debuffs.Add(debuff);
    }

    public void SetAura(AuraEnum aura)
    {
        this.Aura = aura;
    }

    public void SetGlobalEffect(GlobalEffectEnum globalEffect)
    {
        this.GlobalEffect = globalEffect;
    }

    public void SetSpecialEffect(SpecialEffectEnum specialEffect)
    {
        this.SpecialEffect = specialEffect;
    }

    public void TakeDamage(int incomingDamage)
    {
        this.Health = Math.Max(0, this.Health - incomingDamage);
    }

    public bool IsStunned()
    {
        return this.StunRounds > 0;
    }
}

