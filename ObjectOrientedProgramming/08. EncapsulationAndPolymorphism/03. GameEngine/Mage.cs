namespace TheSlum
{
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Interfaces;

    public class Mage : Character, IAttack
    {
        public Mage(string id, int x, int y, Team team):
            base(id, x, y, 150, 50, team, 5)
        {
            this.AttackPoints = 30;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var availableTargets = targetsList.Where(target => target.IsAlive && target.Team != this.Team).ToList();

            if (availableTargets == null || availableTargets.Count == 0)
            {
                return null;
            }

            return availableTargets[availableTargets.Count - 1];
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
