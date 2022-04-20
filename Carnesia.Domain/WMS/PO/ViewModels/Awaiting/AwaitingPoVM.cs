using Carnesia.Domain.WMS.PO.Models;

namespace Carnesia.Domain.WMS.PO.ViewModels.Awaiting;

public class AwaitingPoVM
{
    public string poCode { get; set; }
    public string vendorName { get; set; }
    public string orderDate { get; set; }
    public string rcvDate { get; set; }
    public string rcvStoreName { get; set; }
    public List<PoProductDTO> products { get; set; }
}