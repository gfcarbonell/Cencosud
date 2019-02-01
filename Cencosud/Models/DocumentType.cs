using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cencosud.Models
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public int Digits { get; set; }
    }
}