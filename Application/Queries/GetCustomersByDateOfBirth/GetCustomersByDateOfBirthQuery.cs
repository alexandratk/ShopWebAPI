using Application.DTOs;
using MediatR;

namespace Application.Queries.GetCustomersByDateOfBirth
{
    public class GetCustomersByDateOfBirthQuery : IRequest<IEnumerable<CustomerDTO>>
    {
        public DateTime DateOfBirth { get; set; }
    }
}
