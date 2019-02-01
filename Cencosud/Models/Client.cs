using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cencosud.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int DocumentTypeId { get; set; }
        public string DocumentNumber { get; set; }
        public string RiskProfile { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}