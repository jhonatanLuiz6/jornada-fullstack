using System.Net.Sockets;
using Fina.Core.Enums;

namespace Fina.Core.Models;

public class Transaction
{
    public long Id {get; set;}
    public string Title {get; set;} = string.Empty;
    public DateTime CreateAt {get; set;} = DateTime.Now;
    public DateTime? PaidOrReceivedAt {get; set;}

    public EtransactionType Type {get; set;} = EtransactionType.Withdraw;
    public decimal Amount {get; set;}

    public long CategoryId {get; set;}
    public Category Category {get; set;} = null!;

    public string UserId {get; set;} = string.Empty;

}