using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Request.Transaction;

public class UpdateTransactionRequest : Request
{
    public long Id {get; set;}  

    [Required(ErrorMessage = "Tipo inválido")]
    public EtransactionType Type {get; set;} = EtransactionType.Withdraw;

    [Required(ErrorMessage = "Valor inválido")]
    public decimal Amount {get; set;}

    [Required(ErrorMessage = "Categoria inválida")]
    public long CategoryId {get; set;}

    [Required(ErrorMessage = "Data inválido")]
    public DateTime? PaidOrReceivedAt {get; set;}
}