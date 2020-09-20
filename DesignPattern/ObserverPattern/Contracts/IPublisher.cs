using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Contracts
{
    interface IPublisher
    {
        public void Register(ISubscriber subscriber);

        public void UnRegister(ISubscriber subscriber);

        public void NotifySubscribers();
    }
}
