namespace Carnesia.Domain.CMS.Models;

public class ProductDTO
{
    public int productId { get; set; }
    public string productName { get; set; }
    public string productsku { get; set; }
    public string productCode { get; set; }
    public string weight { get; set; }
    public string productDimension { get; set; }
    public int brandId { get; set; }
    public string brandName { get; set; }
    public bool isPreOrder { get; set; }
    public bool isPublish { get; set; }
    public bool isHasFreeProd { get; set; }
    public int? delivaryDayPreorder { get; set; }
    public string description { get; set; }
    public decimal? mrp { get; set; }
}