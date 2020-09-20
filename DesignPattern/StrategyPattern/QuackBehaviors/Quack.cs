using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.QuackBehaviors
{
    class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack! Quack! Quack!");
        }
    }
}
