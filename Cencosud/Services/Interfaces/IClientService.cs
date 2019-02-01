using Cencosud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cencosud.Services
{
    public interface IClientService : IEntityService<Client>
    {
        Client getClient(int documentTypeId, string documentNumber, int UserId);
        Client firstCall();
    }
}
