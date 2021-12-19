using MediatR;

namespace Meli.Backend.Application.Query.Items.GetByQuery
{
    public class GetByQueryRequestHandler: IRequestHandler<GetByQueryRequest, GetByQueryResponse>
    {
        public Task<GetByQueryResponse> Handle(GetByQueryRequest request, CancellationToken cancellationToken)
        {
            //{
            //    var response = await _service.Search(q, _settings.Value.UrlItemSearch);

            //    return Ok(_mapper.Map<SearchResponse>(response));
            //}

            throw new NotImplementedException();
        }
    }
}
