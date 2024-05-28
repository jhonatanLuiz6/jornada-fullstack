using Fina.Core.Models;
using Fina.Core.Request.Categories;
using Fina.Core.Response;

namespace Fina.Core.Handlers;

public interface ICategoryHandler
{
    Task<Response<Category?>> CreateAscync(CreateCategoryRequest request);
    Task<Response<Category?>> UpdateAscync(UpdateCategoryRequest request);
    Task<Response<Category?>> DeleteAscync(DeleteCategoryRequest request);
    Task<PagedResponse<List<Category>?>> GetAllAscync(GetAllategoryRequest request);
    Task<Response<Category?>> GetByldAscync(GetCategoryByldRequest request);
}