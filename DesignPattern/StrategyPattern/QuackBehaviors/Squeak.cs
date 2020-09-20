using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern.QuackBehaviors
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            // Squeak means the sound by model duck/ rubber duck
            Console.WriteLine("Squeak! Squeak! Squeak!");
        }
    }
}
