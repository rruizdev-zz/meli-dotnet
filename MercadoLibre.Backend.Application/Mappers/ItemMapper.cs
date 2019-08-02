using AutoMapper;
using MercadoLibre.Backend.Domain.Models.Items;
using MercadoLibre.Backend.Domain.Responses;
using MercadoLibre.Backend.Domain.Responses.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MercadoLibre.Backend.Application.Mappers
{
    public class ItemMapper : Profile
    {
        public ItemMapper()
        {
            CreateMap<Search, SearchResponse>()
                .ForMember(d => d.Categories, o => o.MapFrom(s => GetCategories(s.Filters)))
                .ForMember(d => d.Items, o => o.MapFrom(s => GetItems(s.Results)));

            CreateMap<Detail, DetailResponse>()
                .ForMember(d => d.Item, o => o.MapFrom(s => GetDetail(s)));
        }

        private object GetDetail(Detail result)
        {
            var price = result.Price.GetValueOrDefault(0);

            var decimals = price - Math.Truncate(price);

            return new DetailItemResponse
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
                FreeShipping = result.Shipping?.FreeShipping != null && (bool)result.Shipping?.FreeShipping,
                Description = result.Description.PlainText,
                SoldQuantity = result.SoldQuantity.GetValueOrDefault(0)
            };
        }

        private static IList<string> GetCategories(IList<SearchFilter> filters)
        {
            var subject = filters.FirstOrDefault(f => f.Id == "category")?.Values.FirstOrDefault();

            if (subject == null)
            {
                return new List<string>();
            }

            var results = new List<string>
            {
                subject.Name
            };

            results.AddRange(subject.PathFromRoot.Select(p => p.Name));

            return results;

        }

        private static IList<SearchItemResponse> GetItems(IList<Result> results)
        {
            return results.Select(result =>
            {
                var price = result.Price.GetValueOrDefault(0);

                var decimals = price - Math.Truncate(price);

                return new SearchItemResponse
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
                    FreeShipping = result.Shipping?.FreeShipping != null && (bool)result.Shipping?.FreeShipping
                };
            }).ToList();
        }
    }
}
