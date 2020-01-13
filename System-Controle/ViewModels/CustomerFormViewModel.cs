using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System_Controle.Models;

namespace System_Controle.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}