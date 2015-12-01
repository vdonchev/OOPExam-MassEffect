namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public class Laser : ProjectileBase
    {
        public Laser(int damage)
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            int healthDamage = this.Damage - ship.Shields;
            ship.Shields -= this.Damage;
            if (healthDamage > 0)
            {
                ship.Health -= healthDamage;
            }
        }
    }
}