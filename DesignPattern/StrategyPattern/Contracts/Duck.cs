using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Contracts
{
    abstract class Duck
    {
        public IFlyBehavior flyBehavior;

        public IQuackBehavior quackBehavior;

        public abstract void PerformFly();

        public abstract void PerformSound();
    }
}
