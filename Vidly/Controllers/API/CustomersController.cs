using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext(); 
        }

        //GET /api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer,CustomerDto>);
        }

        //GET /api/customers/{id}
        public CustomerDto GetCustomer(int id)
        {
            var customer =_context.Customers.SingleOrDefault(c => c.Id == id); 
            
            if(customer == null)
                throw  new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Customer,CustomerDto>(customer); 
        }

        // POST /api/customerDto/{id}
        [HttpPost] //We are creating a resource 
        public CustomerDto CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto); 
            _context.Customers.Add(customer);
            _context.SaveChanges();
            
            //customerDto.Id = customerDto.Id; 
            return customerDto; 
        }


        // PUT /api/customers/1
        [HttpPut]
        public void UdpateCustomer(int id, Customer customerDto)
        {
            //check state ofthe model
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == customerDto.Id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(customerDto, customerInDb); 

            _context.SaveChanges();
        }


        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id ==  id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove((customerInDb));
            _context.SaveChanges(); 
        }
    }
}
