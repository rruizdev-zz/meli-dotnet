using AutoMapper;
using MercadoLibre.Backend.Domain.Models;
using MercadoLibre.Backend.Domain.Responses;

namespace MercadoLibre.Backend.WebApi.Mappers
{
    public class ItemMapper : Profile
    {
        public ItemMapper()
        {
            CreateMap<ItemByQuery, ItemByQueryResponse>();
        }
    }
}
