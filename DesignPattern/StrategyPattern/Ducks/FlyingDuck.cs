using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Ducks
{
    class FlyingDuck : Duck
    {
        public FlyingDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }

        public override void PerformFly()
        {
            this.flyBehavior.Fly();
        }

        public override void PerformSound()
        {
            this.quackBehavior.Quack();
        }
    }
}
