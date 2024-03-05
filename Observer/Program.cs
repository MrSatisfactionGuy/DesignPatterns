using Observer.Classes;
using Observer.Interface;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- Vorteil ---
            // Der Observer muss die verschiendenen Sensoren nicht kennen
            // => Reduzierung von Abhängigkeiten
            // => neue Observer implementierung ohne irgendwas zu verändern - Observer implementieren, Observer erben. Fertig.
            //
            // --- Nachteil ---
            // Jeder Observer wird informiert, wenn sich etwas ändert.
            // bei Objekten mit vielen Werten problematisch
            // evtl. nur bestimmte Properties interessant

            TemperatureSubject sensor = new TemperatureSubject();
            IObserver notiObserver = new NotificationObserver();
            IObserver displayObserver = new DisplayObserver();

            sensor.Register(notiObserver);
            sensor.Register(displayObserver);

            sensor.Temperature = 1;
            sensor.Temperature = 20;

            Console.ReadKey();
        }
    }
}
