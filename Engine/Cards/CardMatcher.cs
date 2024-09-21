using Duelist.Engine.Cards;
using Duelist.Engine.Players;

public class CardMatcher
{
    private ProfessionEnum playerProfession;

    public CardMatcher(ProfessionEnum playerProfession)
    {
        this.playerProfession = playerProfession;
    }

    public Card? GetMatchingAttackCard(object attackType)
    {
        if (playerProfession == ProfessionEnum.WARRIOR)
        {
        }

        if (playerProfession == ProfessionEnum.GUARDIAN)
        {
            switch (attackType)
            {
                case GuardianAttackEnum.SHIELD_BASH:
                    return new ShieldBashCard();
                case GuardianAttackEnum.DEFENDER_STRIKE:
                    return new DefenderStrikeCard();
                case GuardianAttackEnum.FORTRESS_SLAM:
                    return new FortressSlamCard();
                case GuardianAttackEnum.IRON_WALL:
                    return new IronWallCard();
                case GuardianAttackEnum.EARTH_SHATTER:
                    return new EarthShatterCard();
            }
        }

        if (playerProfession == ProfessionEnum.ASSASSIN)
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
            }
        }

        if (playerProfession == ProfessionEnum.NECROMANCER)
        {
            switch (attackType)
            {
                case NecromancerAttackEnum.SOUL_STRIKE:
                    return new SoulStrikeCard();
                case NecromancerAttackEnum.BONE_SPIKE:
                    return new BoneSpikeCard();
                case NecromancerAttackEnum.SHADOW_GRASP:
                    return new ShadowGraspCard();
                case NecromancerAttackEnum.DEATHLY_DRAIN:
                    return new DeathlyDrainCard();
                case NecromancerAttackEnum.MARK_OF_DEATH:
                    return new MarkOfDeathCard();
            }
        }

        if (attackType is BasicAttackEnum basicAttack)
        {
            return new BasicAttackCard(basicAttack);
        }

        return null;
    }
}
