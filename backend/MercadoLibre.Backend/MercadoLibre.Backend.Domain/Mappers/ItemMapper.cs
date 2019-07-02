using AutoMapper;
using MercadoLibre.Backend.Domain.Models;
using MercadoLibre.Backend.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MercadoLibre.Backend.Domain.Mappers
{
    public class ItemMapper : Profile
    {
        public ItemMapper()
        {
            CreateMap<ItemByQuery, ItemByQueryResponse>()
                .ForMember(d => d.Categories, o => o.MapFrom(s => GetCategories(s.Filters)))
                .ForMember(d => d.Items, o => o.MapFrom(s => GetItems(s.Results)));
        }

        private IList<string> GetCategories(IList<ItemByQueryFilter> filters)
        {
            KeyValueAttribute subject = filters
                .FirstOrDefault(f => f.Id == "category").Values.FirstOrDefault();

            var results = new List<string>
            {
                subject.Name
            };

            results.AddRange(subject.PathFromRoot.Select(p => p.Name));

            return results;
        }

        private IList<ItemResponse> GetItems(IList<ItemResult> results)
        {
            return results.Select(result =>
            {
                var price = result.Price.GetValueOrDefault(0);

                var decimals = price - Math.Truncate(price);

                return new ItemResponse
                {
                    Id = result.Id,
                    Title = result.Title,
                    Price = new PriceResponse
                    {
                        Amount = price,
                        Decimals = decimals * 100,
                        Currency = result.CurrencyId
                    },
                    Picture = result.Thumbnail,
                    Condition = result.Condition,
                    FreeShipping = (bool)result.Shipping?.FreeShipping
                };
            }).ToList();
        }
    }
}
