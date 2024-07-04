using CaseStudy.Application.Repositories;
using MediatR;

namespace CaseStudy.Api.CustomCqrsMediator.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        IProductWriteRepository _productWriteRepository;
        public CreateProductCommandHandler(IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
        }

        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            bool save = await _productWriteRepository.AddAsync(new Domain.Entities.Product
            {
                Name = request.Name,
                Stock = request.Stock,
                Price = (long)request.Price,
                Product_Description = request.Name + " MediatR Kayıt"
            });
            await _productWriteRepository.SaveAsync();

            return await Task.FromResult(new CreateProductCommandResponse { Code = save, Message = save == true ? "Kayıt Başarılı" : "İşlem Başarısız" });
        }
    }
}