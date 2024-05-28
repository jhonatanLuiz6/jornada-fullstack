using System.Net.Sockets;

namespace Fina.Core.Request.Categories;

public class DeleteCategoryRequest : Request
{
    public long Id {get; set;}

}