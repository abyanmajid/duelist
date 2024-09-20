using Duelist.Engine.Players;

public abstract class Card
{
    public const int LEVEL_ONE_PROFESSION_PIP_COST = 4;
    public const int LEVEL_TWO_PROFESSION_PIP_COST = 5;
    public const int LEVEL_THREE_PROFESSION_PIP_COST = 6;
    public const int LEVEL_FOUR_PROFESSION_PIP_COST = 7;
    public const int LEVEL_FIVE_PROFESSION_PIP_COST = 8;

    public abstract object Type { get; }
    public abstract int PipCost { get; }

    public abstract void Cast(Player player, Player enemy);
}