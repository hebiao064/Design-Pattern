using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.FlyBehaviors
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Sorry I cannot Fly");
        }
    }
}
