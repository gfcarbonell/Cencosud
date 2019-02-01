using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cencosud.Models;
using Cencosud.Repositories;

namespace Cencosud.Services
{
    public class ClientService : IClientService
    {
        private IClientRepository IClientRepository;
        public ClientService(IClientRepository IClientRepository)
        {
            this.IClientRepository = IClientRepository;
        }
        public bool Delete(int id)
        {
            return this.IClientRepository.Delete(id);
        }

        public Client firstCall()
        {
            return this.IClientRepository.firstCall();
        }

        public ICollection<Client> Get()
        {
            return this.IClientRepository.Get();
        }

        public Client getClient(int documentTypeId, string documentNumber, int UserId)
        {
            return this.IClientRepository.getClient(documentTypeId, documentNumber, UserId);
        }

        public Client Post(Client t)
        {
            return this.IClientRepository.Post(t);
        }

        public Client Put(Client t)
        {
            return this.IClientRepository.Put(t);
        }
    }
}