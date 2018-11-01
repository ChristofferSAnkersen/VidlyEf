using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyEf.Models;

namespace VidlyEf.ViewModels
{
    public class CustomerFormViewModel
    {
        //public List<MembershipType> MembershipTypes { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}