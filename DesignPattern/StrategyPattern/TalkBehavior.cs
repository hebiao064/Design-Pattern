using DesignPattern.StrategyPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StrategyPattern
{
    class TalkBehavior : ITalkBehavior
    {
        public void Talk()
        {
            Console.WriteLine("I can talk");
        }
    }
}
