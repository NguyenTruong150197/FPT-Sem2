﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    internal class Lion : Animal
    {
        public Lion(string name, double weight)
        {
            SetMe(name, weight);
        }

        public override void Show()
        {
            base.Show();
        }
    }
}
