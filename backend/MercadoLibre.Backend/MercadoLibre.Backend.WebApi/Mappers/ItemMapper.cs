using AutoMapper;
using MercadoLibre.Backend.Domain.Models;
using MercadoLibre.Backend.Domain.Responses;
using System.Collections.Generic;
using System.Linq;

namespace MercadoLibre.Backend.WebApi.Mappers
{
    public class ItemMapper : Profile
    {
        public ItemMapper()
        {
            CreateMap<ItemByQuery, ItemByQueryResponse>()
                .ForMember(d => d.Categories, o => o.MapFrom(s => GetCategories(s.Filters)));
        }

        private IList<string> GetCategories(IList<ItemByQueryFilter> filters)
        {
            var categoryObject = filters.FirstOrDefault(f => f.Id == "category").Values.FirstOrDefault();

            var categoryResults = new List<string>
            {
                categoryObject.Name
            };

            categoryResults.AddRange(categoryObject.PathFromRoot.Select(p => p.Name));

            return categoryResults;
        }
    }
}
