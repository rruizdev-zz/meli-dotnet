using MediatR;

namespace Meli.Backend.Application.Query.Items.GetByCode
{
    public class GetByCodeRequestHandler: IRequestHandler<GetByCodeRequest, GetByCodeResponse>
    {
        public Task<GetByCodeResponse> Handle(GetByCodeRequest request, CancellationToken cancellationToken)
        {
            //{
            //    var response = await _service.DetailWithDescription(id, _settings.Value.UrlItemDetail, _settings.Value.UrlItemDescription);

            //    return Ok(_mapper.Map<DetailResponse>(response));
            //}

            throw new NotImplementedException();
        }
    }
}
