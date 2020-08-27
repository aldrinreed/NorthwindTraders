using AutoMapper;
using Northwind.Application.Common.Mappings;
using Northwind.Domain.Entities;

namespace Northwind.Application.Customers.Queries.GetCustomersList
{
    public class CustomerLookupDto : IMapFrom<Customer>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set;}
        public string City { get; set; }
        public string ContactName{ get; set; }
        public string ContactTitle{ get; set; }
        public string Fax{ get; set; }
        public string Phone{ get; set; }
        public string PostalCode{ get; set; }

        

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Customer, CustomerLookupDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.CustomerId))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.CompanyName))
                .ForMember(d => d.Address, opt => opt.MapFrom(s => s.Address))
                .ForMember(d => d.City, opt => opt.MapFrom(s => s.City))
                .ForMember(d => d.ContactName, opt => opt.MapFrom(s => s.ContactName))
                .ForMember(d => d.ContactTitle, opt => opt.MapFrom(s => s.ContactTitle))
                .ForMember(d => d.Fax, opt => opt.MapFrom(s => s.Fax))
                .ForMember(d => d.Phone, opt => opt.MapFrom(s => s.Phone))
                .ForMember(d => d.PostalCode, opt => opt.MapFrom(s => s.PostalCode));
        }
    }
}
