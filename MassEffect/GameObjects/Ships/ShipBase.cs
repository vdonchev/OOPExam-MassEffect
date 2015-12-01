namespace MassEffect.GameObjects.Ships
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Enhancements;
    using Interfaces;
    using Locations;

    public abstract class ShipBase : IStarship
    {
        private readonly IList<Enhancement> enhancements = new List<Enhancement>();

        protected ShipBase(
            string name,
            int health,
            int shields,
            int damage,
            double fuel,
            StarSystem location)
        {
            this.Name = name;
            this.Health = health;
            this.Shields = shields;
            this.Damage = damage;
            this.Fuel = fuel;
            this.Location = location;
        }


        public string Name { get; set; }

        public int Health { get; set; }

        public int Shields { get; set; }

        public int Damage { get; set; }

        public double Fuel { get; set; }

        public StarSystem Location { get; set; }

        public IEnumerable<Enhancement> Enhancements
        {
            get
            {
                return this.enhancements;
            }
        }

        public void AddEnhancement(Enhancement enhancement)
        {
            this.enhancements.Add(enhancement);
            this.ApplyEnhancement(enhancement);
        }

        private void ApplyEnhancement(Enhancement enhancement)
        {
            this.Shields += enhancement.ShieldBonus;
            this.Damage += enhancement.DamageBonus;
            this.Fuel += enhancement.FuelBonus;
        }

        public abstract IProjectile ProduceAttack();

        public virtual void RespondToAttack(IProjectile attack)
        {
            attack.Hit(this);
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine($"--{this.Name} - {this.GetType().Name}");

            if (this.Health > 0)
            {
                res.AppendLine($"-Location: {this.Location.Name}");
                res.AppendLine($"-Health: {this.Health}");
                res.AppendLine($"-Shields: {this.Shields}");
                res.AppendLine($"-Damage: {this.Damage}");
                res.AppendLine($"-Fuel: {this.Fuel:F1}");
                res.AppendLine($"-Enhancements: {(this.enhancements.Any() ? string.Join(", ", this.enhancements.Select(e => e.Name)) : "N/A")}");
            }
            else
            {
                res.AppendLine("(Destroyed)");
            }

            return res.ToString().Trim();
        }
    }
}