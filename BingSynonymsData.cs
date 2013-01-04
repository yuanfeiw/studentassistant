using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using System.Linq;
using System.Net;

namespace Student_Assistant
{
    public class BingSynonymsData
    {
        private const string USER_ID = "yourLiveId";
        private const string SECURE_ACCOUNT_ID = "plY/WOpjJ6rUqn+72U3hQC82AbSm1v7DNP7EceG02MI=";  // not your Live password
        private const string ROOT_SERVICE_URL = "https://api.datamarket.azure.com/Data.ashx/Bing/Synonyms/v1";

        private Uri serviceUri;
        private BingSynonymsContainer context;
        private DataServiceCollection<GetSynonymsEntitySet> dataCollection;

        public ObservableCollection<string> SynonymsList { get; set; }

        public BingSynonymsData()
        {
            serviceUri = new Uri(ROOT_SERVICE_URL);
            context = new BingSynonymsContainer(serviceUri);
            context.IgnoreMissingProperties = true;
            context.Credentials = new NetworkCredential(USER_ID, SECURE_ACCOUNT_ID);
            dataCollection = new DataServiceCollection<GetSynonymsEntitySet>(context);

            SynonymsList = new ObservableCollection<string>();
            dataCollection.LoadCompleted += new EventHandler<LoadCompletedEventArgs>(dataCollection_LoadCompleted);
        }

        // queries the dataset and returns the resultset (or null)
        public void GetSynonyms(string queryStr)
        {
            try
            {
                DataServiceQuery<GetSynonymsEntitySet> query = context.GetSynonyms(queryStr);
                dataCollection.LoadAsync(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Census ERROR {0}",ex.Message);
            }
        }

        private void dataCollection_LoadCompleted(object sender, LoadCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                List<GetSynonymsEntitySet> list = dataCollection.ToList();

                SynonymsList.Clear();
                foreach (var entity in list)
                {
                    SynonymsList.Add(entity.Synonym);
                }
            }
            else
            {
                Console.WriteLine(e.Error.ToString());
            }
        }
    }
}
