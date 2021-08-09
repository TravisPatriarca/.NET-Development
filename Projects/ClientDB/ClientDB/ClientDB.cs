using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientDB
{
    class ClientDB
    {
        private string companyName;
        private int totalClients;
        private const int MAX_CLIENTS = 100;
        private Client[] myClients;

        public ClientDB(string companyName)
        {
            this.companyName = companyName;
            totalClients = 0;
            myClients = new Client[MAX_CLIENTS];
        }

        public bool AddClient(string clientName)
        {
            //find an empty slot in myClients array
            int index = -1;
            for (int i=0; i<MAX_CLIENTS; i++) {
                if (myClients[i] == null) {
                    index = i;
                    break;
                }
            }

            if(index != -1) {
                myClients[index] = new Client(clientName);

                ++totalClients;
                return true;
            }

            return false;
        }

        public bool RemoveClient(string clientName)
        {
            for (int i=0; i<MAX_CLIENTS; ++i) {
                if (myClients[i] != null) {
                    if (myClients[i].IsSame(clientName)) {
                        myClients[i] = null;
                        --totalClients;

                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsAClient(string clientName)
        {
            for (int i=0; i<MAX_CLIENTS; ++i) {
                if (myClients[i] != null) {
                    if (myClients[i].IsSame(clientName)) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
