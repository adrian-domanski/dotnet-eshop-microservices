using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string ImageFile, string Name, string? Description, decimal Price,
    List<string> Category) : IRequest<CreateProductResult>;

public record CreateProductResult(Guid Id);

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}