using Serenity.Services;

namespace AR_00002_SereneSample.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}