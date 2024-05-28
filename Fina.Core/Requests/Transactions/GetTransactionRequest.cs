using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Request.Transaction;

public class GEtTransactionRequest : Request
{
    public long Id {get; set;}
}