namespace MassEffect.GameObjects.Ships
{
    using System;
    using System.Text;
    using Enhancements;
    using Interfaces;
    using Locations;
    using Projectiles;

    public class Frigate : ShipBase
    {
        private const int FrigateHealth = 60;
        private const int FrigateShields = 50;
        private const int FrigateDamage = 30;
        private const double FrigateFuel = 220;

        private int projectilesFired;

        public Frigate(string name, StarSystem location)
            : base(name,
                  FrigateHealth,
                  FrigateShields,
                  FrigateDamage,
                  FrigateFuel,
                  location)
        {
        }

        public override IProjectile ProduceAttack()
        {
            this.projectilesFired++;
            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine(base.ToString());
            if (this.Health > 0)
            {
                res.AppendLine($"-Projectiles fired: {this.projectilesFired}");
            }

            return res.ToString().Trim();
        }
    }
}