using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace try2
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<NotHotDogModel> notHotDogTable;


        private AzureManager()
        {
            this.client = new MobileServiceClient("http://module2try.azurewebsites.net");
            this.notHotDogTable = this.client.GetTable<NotHotDogModel>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }
        public async Task<List<NotHotDogModel>> GetHotDogInformation()
        {
            return await this.notHotDogTable.ToListAsync();
        }
    }
}
