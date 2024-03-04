namespace Singleton.Context
{
    internal class UserContext
    {
        //frühe initialisierung
        //von Haus aus initialisiert
        static UserContext instance = new UserContext();

        //späte initialisierung
        //static UserContext instance;

        //sichtbarkeit von CTOR verhindert, dass von UserContext ein Objekt erstellt wird
        private UserContext() { }


        // statische Eigenschaft => ermöglicht Zugriff auf eine Instanz dieses Objekts
        public static UserContext Instance
        {
            get
            {
                //später Zugriff:
                //if (instance == null) instance = new UserContext();
                return instance;
            }
        }

        public string UserName { get; private set; }
        public string Password { get; private set; }

        public bool Load()
        {
            return true;
        }

    }
}
