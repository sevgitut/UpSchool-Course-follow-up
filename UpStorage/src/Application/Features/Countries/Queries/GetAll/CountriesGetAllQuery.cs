using MediatR;

namespace Application.Features.Countries.Queries.GetAll
{
    public class CountriesGetAllQuery : IRequest<List<CountriesGetAllDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}