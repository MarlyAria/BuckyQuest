﻿using System;
using System.Drawing;

namespace BuckyQuest
{
    internal class BluePotion : Weapon , IPotion
    {
        public BluePotion(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Blue Potion"; } }

        public bool Used => throw new System.NotImplementedException();

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}