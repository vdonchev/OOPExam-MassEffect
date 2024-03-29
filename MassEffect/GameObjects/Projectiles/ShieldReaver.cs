﻿namespace MassEffect.GameObjects.Projectiles
{
    using Interfaces;

    public class ShieldReaver : ProjectileBase
    {
        public ShieldReaver(int damage) 
            : base(damage)
        {
        }

        public override void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
            ship.Shields -= this.Damage * 2;
        }
    }
}