using DesignPattern.ObserverPattern;
using DesignPattern.ObserverPattern.Contracts;
using DesignPattern.ObserverPattern.Models;
using DesignPattern.StrategyPattern;
using DesignPattern.StrategyPattern.Contracts;
using DesignPattern.StrategyPattern.Ducks;
using DesignPattern.StrategyPattern.FlyBehaviors;
using DesignPattern.StrategyPattern.QuackBehaviors;
using System;
using System.Runtime.InteropServices;

namespace DesignPattern
{
    class Program
    {
        /// <summary>
        /// Referecence: Head First Design Patterns
        /// https://learning.oreilly.com/library/view/head-first-design/0596007124/
        /// </summary>
        /// <param name="args">the args</param>
        static void Main(string[] args)
        {
            // 1. Strategy Pattern
            RunStrategyPatternDemo();

            // 2. Observer Pattern
            RunObserverPatternDemo();

            Console.WriteLine("Hello World!");
        }

        // 1. Strategy Pattern
        private static void RunStrategyPatternDemo()
        {
            // Normal Duck can not fly
            // Normal Duck can Quack
            Console.WriteLine("Initializing a Normal Duck");
            Duck normalDuck = new NormalDuck(new FlyNoWay(), new Quack());
            normalDuck.PerformFly();
            normalDuck.PerformSound();
            Console.WriteLine();

            // Flying Duck can fly
            // Flying Duck can Quack
            Console.WriteLine("Initializing a Flying Duck");
            Duck flyingDuck = new FlyingDuck(new FlyWithWings(), new Quack());
            flyingDuck.PerformFly();
            flyingDuck.PerformSound();
            Console.WriteLine();

            // Electronic Duck can not fly
            // Electronic Duck can Quack like Squeak
            // Electronic Duck can talk!
            Console.WriteLine("Initializing a Electronic Duck");
            Duck electronicDuck = new ElectronicDuck(new FlyNoWay(), new Squeak(), new TalkBehavior());
            electronicDuck.PerformFly();
            electronicDuck.PerformSound();
            Console.WriteLine();
        }

        // 2. Observer Pattern
        private static void RunObserverPatternDemo()
        {
            WeatherPublisher weatherPublisher = new WeatherPublisher();
            ISubscriber currentConditionDisplay = new CurrentConditionsDisplay(weatherPublisher);
            ISubscriber statisticalDisplay = new StatisticalDisplay(weatherPublisher);

            Console.WriteLine("Set Weather the first time");
            weatherPublisher.SetWeatherStats(0, 0, 0);
            Console.WriteLine();

            Console.WriteLine("Set Weather the second time");
            weatherPublisher.SetWeatherStats(1, 1, 1);
            Console.WriteLine();

            Console.WriteLine("Unsubscribe Current Condition Display");
            currentConditionDisplay.UnSubscribe();

            Console.WriteLine("Set Weather the third time");
            weatherPublisher.SetWeatherStats(2, 2, 2);
            Console.WriteLine();

            Console.WriteLine("Unsubscribe Current Statistical Display");
            statisticalDisplay.UnSubscribe();

            Console.WriteLine("Set Weather the fourth time");
            weatherPublisher.SetWeatherStats(3, 3, 3);
            Console.WriteLine();
        }
    }
}
