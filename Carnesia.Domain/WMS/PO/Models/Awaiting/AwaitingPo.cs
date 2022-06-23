namespace Carnesia.Domain.WMS.PO.Models.Awaiting;

public class AwaitingPo
{
    public string poCode { get; set; }
    public string orderDate { get; set; }
    public string vendorName { get; set; }
    public int poQuantity { get; set; }
    public decimal totalAmount { get; set; }
    public string? poStatus { get; set; }
    public string? statusUpdateDate { get; set; }
}