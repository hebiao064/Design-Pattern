using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.FlyBehaviors
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can Fly with wings!");
        }
    }
}
