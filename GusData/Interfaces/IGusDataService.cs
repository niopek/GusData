using GusData.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusData.Interfaces
{
    public interface IGusDataService
    {
        Task<ObservableCollection<Section>> GetData();
    }
}
