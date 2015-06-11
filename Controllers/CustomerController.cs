using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using MyCustomers;
using MyCustomers.Models;

namespace MyCustomers.Controllers
{
 
    public class CustomerController : Controller
    {        
        private readonly ICustomerRepository _customerRepository;
        
        public CustomerController()
        {
            _customerRepository= new CustomerRepository();
        }
         
		 public IActionResult Index()
        {
            return View(_customerRepository.GetCutomers());
        }
	}
}	