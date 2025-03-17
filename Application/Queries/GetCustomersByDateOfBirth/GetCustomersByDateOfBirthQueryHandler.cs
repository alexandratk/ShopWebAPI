using Application.Common;
using Application.DTOs;
using Application.Services.CustomerN;
using AutoMapper;
using Domain.Core.Entities;

namespace Application.Queries.GetCustomersByDateOfBirth
{
    internal class GetCustomersByDateOfBirthQueryHandler(ICustomerService _customerService, IMapper _mapper)
        : IQueryHandler<GetCustomersByDateOfBirthQuery, IEnumerable<CustomerDTO>>
    {
        public async Task<IEnumerable<CustomerDTO>> Handle(GetCustomersByDateOfBirthQuery request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request);

            IEnumerable<Customer> customers = await _customerService.GetCustomersByDateOfBirth(request.DateOfBirth);

            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDTO>>(customers);
        }
    }
}
