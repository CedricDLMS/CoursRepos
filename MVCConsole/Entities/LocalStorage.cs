using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class LocalStorage
    {
        private static LocalStorage instance = null;
        public List<Employe> Employes { get; set; }
        // Verrou pour garantir la thread-safety
        private static readonly object padlock = new object();
        private LocalStorage()
        {
            Employes = new List<Employe>();
        }

        public static LocalStorage Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LocalStorage();
                    }
                    return instance;
                }
            }
        }

    }
}
