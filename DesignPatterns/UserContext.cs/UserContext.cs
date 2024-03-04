using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.UserContext.cs
{
    class UserContext
    {
        // von Haus aus initialisiert
        // auch bekannt als "frühe Initialisierung"
        static UserContext instance = new UserContext();

        //später zugriff
        //static UserContext instance;


        // private CTOR verhindert, dass von UserContext ein Objekt erzeugt wird
        private UserContext() { }

        // statische Eigenschaft 
        // soll den Zugriff auf eine Instanz dieses Objekts zu ermöglichen
        public static UserContext Instance
        {
            get {
                //später zugriff
                //if (instance == null) instance = new UserContext();
                return instance; 
            }

        }

        public int UserID {  get; private set; }
        public string UserName { get; private set; }

        public bool Load()
        {
            //Load Data from somewhere
            return true;
        }
    }
}
