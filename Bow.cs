using System;
using System.Drawing;

namespace BuckyQuest
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Bow"; } }

        public override void Attack(Direction direction, Random random)
        {
            /*The bow has a very narrow angle of attack, but it’s got a very long
            range—it’s got an attack radius of 30, but only causes 1 point
            of damage.Unlike the sword, which attacks in three directions
            (because the player swings it in a wide arc), when the player shoots
            the bow in a direction, it only shoots in that one direction.*/
            
            switch (direction)
            {
                case Direction.Up:
                    DamageEnemy(Direction.Up, 30, 1, random);
                    break;
                case Direction.Right:
                    DamageEnemy(Direction.Right, 30, 1, random);
                    break;
                case Direction.Down:
                    DamageEnemy(Direction.Down, 30, 1, random);
                    break;
                case Direction.Left:
                    DamageEnemy(Direction.Left, 30, 1, random);
                    break;
                default: break;
            }
        }
    }
}