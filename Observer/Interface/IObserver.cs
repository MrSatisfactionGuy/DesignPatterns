using System.Data;

namespace Observer.Interface
{
    internal interface IObserver
    {
        void Update(float value);
    }
}