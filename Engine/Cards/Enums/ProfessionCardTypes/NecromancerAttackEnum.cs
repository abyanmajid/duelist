public enum NecromancerAttackEnum
{
    SOUL_STRIKE, // inflicts 270, adds a blade, and heals self for 100
    BONE_SPIKE, // inflicts 370, adds a blade, weakness debuffs the enemy, and heals self for 140
    SHADOW_GRASP, // inflicts 520, adds a weakness and curse debuffs the enemy, and heals self for 210
    DEATHLY_DRAIN, // inflicts 720, adds 2 weaknesses and curse debuffs to the enemy, and heals self for 300
    MARK_OF_DEATH, // inflicts 970, sends 2 curse debuff to the enemy, heals self for 600, and enters Drainer mode (sending 1 weakness to the enemy and draining 5% of their health for each of the 3 next rounds)
}