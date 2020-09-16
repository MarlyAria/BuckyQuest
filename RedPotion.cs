using System;
using System.Drawing;

namespace BuckyQuest
{
    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Red Potion"; } }

        public bool Used => throw new System.NotImplementedException();

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}