using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        //loosely coupled code
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        //reuse the large complex object for now 
        public Customer Customer { get; set; }
    }
}