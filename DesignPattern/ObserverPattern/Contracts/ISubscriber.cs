using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern.Contracts
{
    interface ISubscriber
    {
        void Update(float t, float h, float p);
        
        // void Subscribe(IPublisher publisher);

        void UnSubscribe();
    }
}
