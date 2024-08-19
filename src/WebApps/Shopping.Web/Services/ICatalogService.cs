namespace Shopping.Web.Services;

public interface ICatalogService
{
    Task<GetProductResponse> GetProducts(int? pageNumber = 1, int? pageSize = 10);
    Task<GetProductByIdResponse> GetProduc(Guid id);
    Task<GetProductByCategoryResponse> GetProductByCategory(string category);
}
