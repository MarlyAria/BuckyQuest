using System.Drawing;

namespace BuckyQuest
{
    internal class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Mace"; } }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}