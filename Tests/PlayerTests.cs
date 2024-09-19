using Duelist.Engine.Cards.Abstract;
using Duelist.Engine.Players;

namespace Tests;

public class PlayerTests
{
    private Player player;

    public PlayerTests()
    {
        this.player = new Player(null, ProfessionType.Necromancer, new List<Card>());
    }

    [Fact]
    public void PlayerIncreasePip()
    {
        Assert.Equal(1, player.Pips);
        player.IncreasePip();
        Assert.Equal(2, player.Pips);
        player.IncreasePip();
        Assert.Equal(3, player.Pips);
        player.IncreasePip();
        player.IncreasePip();
        Assert.Equal(5, player.Pips);
    }
}