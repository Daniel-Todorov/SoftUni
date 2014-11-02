namespace TheSlum
{
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Interfaces;

    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team) :
            base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = 60;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var availableTargets = targetsList.Where(target => target.IsAlive && target.Team == this.Team).ToList();

            if (availableTargets == null || availableTargets.Count == 0)
            {
                return null;
            }

            return availableTargets.OrderBy(target => target.HealthPoints).First();
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
