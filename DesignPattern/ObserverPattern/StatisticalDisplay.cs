using DesignPattern.ObserverPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    class StatisticalDisplay : ISubscriber, IDisplay
    {
        private IPublisher publisher;

        private float temp;

        private float humidity;

        private float pressure;

        public StatisticalDisplay(IPublisher publisher)
        {
            this.publisher = publisher;
            publisher.Register(this);
        }

        public void Dispaly()
        {
            Console.WriteLine("Statistical Conditions Display: Temp is {0}, Humidity is {1}, Pressure is {2}", temp, humidity, pressure);
        }

        public void UnSubscribe()
        {
            this.publisher.UnRegister(this);
        }

        public void Update(float t, float h, float p)
        {
            this.temp = t;
            this.humidity = h;
            this.pressure = p;
            this.Dispaly();
        }
    }
}
