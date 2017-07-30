using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace try1
{
    public class AzureManager
    {

        private static AzureManager instance;
        private MobileServiceClient client;
        public IMobileServiceTable<CupOfCoffeeModel> coffeeTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://module2try.azurewebsites.net");
            this.coffeeTable = this.client.GetTable<CupOfCoffeeModel>();
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

        public async Task<List<CupOfCoffeeModel>> GetCoffeeInformation()
        {
            return await this.coffeeTable.ToListAsync();
        }

    }
}
