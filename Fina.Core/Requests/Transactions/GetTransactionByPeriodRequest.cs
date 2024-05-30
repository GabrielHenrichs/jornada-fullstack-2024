namespace Fina.Core.Requests.Categories;

public class GetTransactionByPeriodRequest : PagedRequest
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
