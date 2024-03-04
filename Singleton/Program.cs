using Singleton.Context;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Singleton => Globaler Context benötigt
            // Dazu CTOR private setzen
            // Zugriffsmethode / Eigenschaft erstellen, die die Instanz liefert.
            // Bei der späten Initialisierung wird beim ersten Zugriff auf eine Eigenschaft das Objekt initialisiert
            //

            UserContext context = UserContext.Instance;

            if (context != UserContext.Instance) Console.WriteLine("Neuer Speicherbereich belegt - Dies ist eine neue Instanzierung!");

            Console.WriteLine("Die ist die gleiche Instanz! :)");

            if (!context.Load()) Console.WriteLine("Laden fehlgeschlagen");

            Console.WriteLine("Laden erfolgreich!");
            Console.ReadKey();
        }
    }
}
