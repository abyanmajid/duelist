using Duelist.Engine.Cards;

public class CardMatcher
{
    public static object? MatchAttack(object attackType)
    {
        switch (attackType)
        {
            case AssassinAttackEnum.FATEFUL_PUNISHMENT:
                return new FatefulPunishmentCard();
            case AssassinAttackEnum.SHADOW_STRIKE:
                return new ShadowStrikeCard();
            case AssassinAttackEnum.NIGHT_SLASH:
                return new NightSlashCard();
            case AssassinAttackEnum.ASSASSINATION:
                return new AssassinationCard();
            case AssassinAttackEnum.SHADOW_JUDGMENT:
                return new ShadowJudgmentCard();
            default:
                return null;
        }
    }
}
