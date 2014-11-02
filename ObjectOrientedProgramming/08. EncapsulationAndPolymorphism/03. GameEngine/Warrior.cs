namespace TheSlum
{
    using System.Collections.Generic;
    using System.Linq;

    using TheSlum.Interfaces;

    public class Warrior : Character, IAttack
    {
        public Warrior(string id, int x, int y, Team team):
            base(id, x, y, 200, 100, team, 2)
        {
            this.AttackPoints = 150;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var availableTargets = targetsList.Where(target => target.IsAlive && target.Team != this.Team).ToList();

            foreach (var target in availableTargets)
            {
                if (target.IsAlive)
                {
                    return target;
                }
            }

            return null;
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
