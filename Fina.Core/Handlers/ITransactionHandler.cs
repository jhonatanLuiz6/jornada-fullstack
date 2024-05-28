using Fina.Core.Models;
using Fina.Core.Request.Categories;
using Fina.Core.Request.Transaction;
using Fina.Core.Response;

namespace Fina.Core.Handlers;

public interface ITransactionHandler
{
    Task<Response<Transaction?>> CreateAscync(CreateTransactionRequest request);
    Task<Response<Transaction?>> UpdateAscync(UpdateTransactionRequest request);
    Task<Response<Transaction?>> DeleteAscync(DeleteTransactionRequest request);
    Task<PagedResponse<List<Transaction>?>> GetByPeriodAscync(GetTransactionsByPeriod request);
    Task<Response<Transaction?>> GetByldAscync(GEtTransactionRequest request);
}