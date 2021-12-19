using MediatR;

namespace Meli.Backend.Application.Query.Items.GetByQuery
{
    public record GetByQueryRequest(string Query) : IRequest<GetByQueryResponse>;
}
