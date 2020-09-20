using DesignPattern.ObserverPattern.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Models
{
    class WeatherPublisher : IPublisher
    {
        private IList<ISubscriber> subscribers;

        public WeatherPublisher()
        {
            this.subscribers = new List<ISubscriber>();
        }

        public void NotifySubscribers()
        {
            foreach(var sub in subscribers)
            {
                sub.Update(this.temp, this.humidity, this.pressure);
            }
        }

        public void Register(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void UnRegister(ISubscriber subscriber)
        {
            foreach(var sub in subscribers)
            {
                if (sub.Equals(subscriber))
                {
                    subscribers.Remove(sub);
                    return;
                }
            }
        }

        private float temp;

        private float humidity;

        private float pressure;

        public void SetWeatherStats(float t, float h, float p)
        {
            this.temp = t;
            this.humidity = h;
            this.pressure = p;
            this.NotifySubscribers();
        }
    }
}
