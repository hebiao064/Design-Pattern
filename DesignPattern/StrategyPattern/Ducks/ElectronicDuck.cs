using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.Ducks
{
    class ElectronicDuck : Duck, ITalkBehavior
    {
        private ITalkBehavior talkBehavior;

        public ElectronicDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ITalkBehavior talkBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
            this.talkBehavior = talkBehavior;
        }

        public override void PerformFly()
        {
            this.flyBehavior.Fly();
        }

        public override void PerformSound()
        {
            this.quackBehavior.Quack();
        }

        public void Talk()
        {
            this.talkBehavior.Talk();
        }
    }
}
