namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public abstract class ProjectileBase : IProjectile
    {
        protected ProjectileBase(int damage)
        {
            this.Damage = damage;
        } 

        public int Damage { get; set; }

        public abstract void Hit(IStarship ship);
    }
}