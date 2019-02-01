using Cencosud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cencosud.Repositories
{
    public interface IClientRepository : IEntityRepository<Client>
    {
        Client getClient(int documentTypeId, string documentNumber, int UserId);
        Client firstCall();
    }
}
