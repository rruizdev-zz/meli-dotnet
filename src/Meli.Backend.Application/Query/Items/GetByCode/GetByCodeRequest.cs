using MediatR;

namespace Meli.Backend.Application.Query.Items.GetByCode
{
    public record GetByCodeRequest(string Code) : IRequest<GetByCodeResponse>;
}
