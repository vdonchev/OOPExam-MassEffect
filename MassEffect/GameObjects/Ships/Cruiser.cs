namespace MassEffect.GameObjects.Ships
{
    using Enhancements;
    using Interfaces;
    using Locations;
    using Projectiles;

    public class Cruiser : ShipBase
    {
        private const int CruiserHealth = 100;
        private const int CruiserShields = 100;
        private const int CruiserDamage = 50;
        private const double CruiserFuel = 300;

        public Cruiser(string name, StarSystem location)
            : base(name,
                  CruiserHealth,
                  CruiserShields,
                  CruiserDamage,
                  CruiserFuel,
                  location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}