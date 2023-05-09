using GusData.Interfaces;
using GusData.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GusData.Services
{
    public class GusDataService : IGusDataService
    {
        public async Task<ObservableCollection<Section>> GetData()
        {
            ObservableCollection<Section> data = new();
            await Task.Run(async () =>
            {
                var httpClient = new HttpClient();
                var url = "https://api-dbw.stat.gov.pl/api/1.1.0/area/area-area";
                var json = await httpClient.GetStringAsync(url);
                var result = JsonConvert.DeserializeObject<ObservableCollection<Section>>(json);

                if(result != null)
                {
                    data = result;
                }

            });

            return data;
        }
    }
}
