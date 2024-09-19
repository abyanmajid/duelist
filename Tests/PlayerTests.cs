using Duelist.Engine.Players;

namespace Tests;

public class PlayerTests
{
    private static ProfanityFilter.ProfanityFilter _profanityFilter = new ProfanityFilter.ProfanityFilter();

    private Player warrior;
    private Player guardian;
    private Player assassin;
    private Player necromancer;

    public PlayerTests()
    {
        this.warrior = new Player(null, ProfessionEnum.Warrior, new List<object>());
        this.guardian = new Player("Abyan", ProfessionEnum.Guardian, new List<object>());
        this.assassin = new Player("Linus", ProfessionEnum.Assassin, new List<object>());
        this.necromancer = new Player("", ProfessionEnum.Necromancer, new List<object>());
    }

    [Fact]
    public void PlayerValidNamesTest()
    {
        Assert.Equal("Guest", warrior.Name);
        Assert.Equal("Abyan", guardian.Name);
        Assert.Equal("Linus", assassin.Name);
        Assert.Equal("Guest", necromancer.Name);

    }

    [Fact]
    public void PlayerInvalidNamesTest()
    {
        Assert.Throws<ArgumentException>(() => new Player("你好你好你好你好", ProfessionEnum.Warrior, new List<object>()));
        Assert.Throws<ArgumentException>(() => new Player("A-b_y@a#n!$", ProfessionEnum.Warrior, new List<object>()));
        Assert.Throws<ArgumentException>(() => new Player("Fuck", ProfessionEnum.Warrior, new List<object>()));
    }

    [Fact]
    public void PlayerCorrectlyMatchingProfessionTest()
    {
        Assert.Equal("Warrior", warrior.Profession.Name);
        Assert.Equal("Guardian", guardian.Profession.Name);
        Assert.Equal("Assassin", assassin.Profession.Name);
        Assert.Equal("Necromancer", necromancer.Profession.Name);
    }

    [Fact]
    public void PlayerIncorrectlyMatchingProfessionTest()
    {
        Assert.NotEqual("Guardian", warrior.Profession.Name);
        Assert.NotEqual("Assassin", warrior.Profession.Name);
        Assert.NotEqual("Necromancer", warrior.Profession.Name);

        Assert.NotEqual("Warrior", guardian.Profession.Name);
        Assert.NotEqual("Assassin", guardian.Profession.Name);
        Assert.NotEqual("Necromancer", guardian.Profession.Name);

        Assert.NotEqual("Warrior", assassin.Profession.Name);
        Assert.NotEqual("Guardian", assassin.Profession.Name);
        Assert.NotEqual("Necromancer", assassin.Profession.Name);

        Assert.NotEqual("Warrior", necromancer.Profession.Name);
        Assert.NotEqual("Guardian", necromancer.Profession.Name);
        Assert.NotEqual("Assassin", necromancer.Profession.Name);
    }

    [Fact]
    public void PlayerDeckExceedsLimitTest()
    {
        List<object> deckExceedingLimit = new List<object>();

        for (int i = 0; i < 6; i++)
        {
            deckExceedingLimit.Add(AssassinAttackEnum.NIGHT_SLASH);
            deckExceedingLimit.Add(AssassinAttackEnum.SHADOW_STRIKE);
            deckExceedingLimit.Add(AssassinAttackEnum.SILENT_BLADE);
            deckExceedingLimit.Add(AssassinAttackEnum.SHADOW_JUDGMENT);
            deckExceedingLimit.Add(AssassinAttackEnum.SHADOW_JUDGMENT);
        }

        for (int i = 0; i < 3; i++)
        {
            deckExceedingLimit.Add(WarriorAttackEnum.RAPID_SLASH);
            deckExceedingLimit.Add(WarriorAttackEnum.POWER_STRIKE);
            deckExceedingLimit.Add(WarriorAttackEnum.BLADE_STORM);
            deckExceedingLimit.Add(WarriorAttackEnum.RAGING_FURY);
            deckExceedingLimit.Add(WarriorAttackEnum.TITAN_SLAM);
        }

        Assert.Throws<ArgumentException>(() => new Player("Abyan", ProfessionEnum.Assassin, deckExceedingLimit));
    }

    [Fact]
    public void PlayerIncreasePipTest()
    {
        Assert.Equal(1, warrior.Pips);
        warrior.IncreasePip();
        Assert.Equal(2, warrior.Pips);
        warrior.IncreasePip();
        Assert.Equal(3, warrior.Pips);
        warrior.IncreasePip();
        warrior.IncreasePip();
        Assert.Equal(5, warrior.Pips);
    }
}