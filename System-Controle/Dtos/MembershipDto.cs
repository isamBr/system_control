using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System_Controle.Dtos
{
    public class MembershipDto
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public byte DiscountRate { get; set; }
    }
}