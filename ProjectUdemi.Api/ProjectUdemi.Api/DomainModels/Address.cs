using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUdemi.Api.DomainModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhisicalAddress { get; set; }
        public string PostalAddress { get; set; }
        
       
        public Guid StudentId { get; set; }
    }
}
