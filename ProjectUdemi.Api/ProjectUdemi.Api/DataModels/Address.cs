using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectUdemi.Api.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhisicalAddress { get; set; }
        public string PostalAddress { get; set; }
        
        //Nagigation Property
        public Guid StudentId { get; set; }
    }
}
