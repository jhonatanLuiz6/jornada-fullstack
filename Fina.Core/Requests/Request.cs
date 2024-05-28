using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Request;

public abstract class Request
{
    public string UserId {get; set;} = string.Empty;
}