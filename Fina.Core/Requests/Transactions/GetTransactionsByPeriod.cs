using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Request.Transaction;

public class GetTransactionsByPeriod : Request
{
    public DateTime? StartDate { get; set;}
    public DateTime? EndDate {get; set;}
}