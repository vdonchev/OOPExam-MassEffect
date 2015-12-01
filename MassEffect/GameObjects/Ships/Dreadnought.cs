namespace MassEffect.GameObjects.Ships
{
    using Enhancements;
    using Interfaces;
    using Locations;
    using Projectiles;

    public class Dreadnought : ShipBase
    {
        private const int DreadnoughtHealth = 200;
        private const int DreadnoughtShields = 300;
        private const int DreadnoughtDamage = 150;
        private const double DreadnoughtFuel = 700;

        public Dreadnought(string name, StarSystem location)
            : base(name,
                  DreadnoughtHealth,
                  DreadnoughtShields,
                  DreadnoughtDamage,
                  DreadnoughtFuel,
                  location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            int totalDamage = (this.Shields / 2) + this.Damage;
            return new Laser(totalDamage);
        }

        public override void RespondToAttack(IProjectile attack)
        {
            this.Shields += 50;
            base.RespondToAttack(attack);
            this.Shields -= 50;
        }
    }
}