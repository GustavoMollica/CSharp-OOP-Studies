
namespace RPGCharacter.Models
{
    public class Character
    {        
        private int _hitPointsMax = 100;
        private int _baseAttackPower = 15;
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; private set; }
        public int HitPoints { get; private set; }
        public int AttackPower { get; private set; }
        public bool IsDead => HitPoints == 0;

        public Character(string name, string classCharacter)
        {
            Name = name;
            Class = classCharacter;
            Level = 1;
            HitPoints = _hitPointsMax;
            AttackPower = _baseAttackPower;
        }

        public void LevelUp()
        {
            const int pointsHPNextLevel = 20;
            const int pointsAPNextLevel = 5;
            const int pointsMaxHPNextLevel = 20;

            Level += 1;
            AttackPower += pointsAPNextLevel;
            _hitPointsMax += pointsMaxHPNextLevel;
            
            HitPoints = Math.Min(_hitPointsMax, HitPoints + pointsHPNextLevel);
        }

        public bool Heal(int xpHeal)
        {
            if (IsDead || xpHeal < 0)
                return false;

            HitPoints = Math.Min(_hitPointsMax, HitPoints + xpHeal);
            return true;
        }

        public bool TakeDamage(int damage)
        {
            if (IsDead || damage < 0)
                return false;

            HitPoints -= Math.Min(damage, HitPoints);

            return true;
        }

        public override string ToString()
        {
            return $"Nivel {Level} - HP: {HitPoints}/{_hitPointsMax} - Ataque: {AttackPower}";
        }
    }
}
