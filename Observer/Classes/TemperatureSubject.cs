using Observer.Interface;

namespace Observer.Classes
{
    class TemperatureSubject
    {
        List<IObserver> registertObsi = new List<IObserver>();

        float temp;

        public float Temperature
        {
            get => temp;
            set
            {
                if (temp != value)
                {
                    temp = value;
                    this.Update();
                }
            }
        }

        public void Register(IObserver obsi)
        {
            if (obsi != null) registertObsi.Add(obsi);
        }

        public void Unregister(IObserver obsi)
        {
            if (obsi != null) registertObsi.Remove(obsi);
        }


        private void Update()
        {
            foreach (IObserver o in registertObsi)
            {
                o.Update(this.Temperature);
            }
        }
    }
}
