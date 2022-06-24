namespace Carnesia.Domain.WMS.PO.Models;

public class SkuHistory
{
        public string poCode { get; set; }
        public string sku { get; set; }
        public string productName { get; set; }
        public int receivedQty { get; set; }
        public decimal liftingPrice { get; set; }
}