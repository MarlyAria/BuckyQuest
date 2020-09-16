using System;
using System.Drawing;

namespace BuckyQuest
{
    internal class Sword : Weapon
    {
        public Sword(Game game, Point location): base(game, location) { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}