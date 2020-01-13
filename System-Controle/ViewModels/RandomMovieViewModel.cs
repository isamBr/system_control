using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System_Controle.Models;

namespace System_Controle.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}