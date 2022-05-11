using Skote.edmx;
using Skote.Services.Master.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skote.Services.Master
{
    public interface IMasterAppServices
    {
        List<MasterListDto> GetAll();
        //void SaveOrder(string name, String address, Order[] order);
    }
}
