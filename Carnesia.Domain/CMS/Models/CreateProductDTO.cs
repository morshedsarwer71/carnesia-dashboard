namespace Carnesia.Domain.CMS.Models;

public class CreateProductDTO
{
    public ProductDTO productDTO { get; set; }
    public List<ProdCategory> prodCategories { get; set; } = new List<ProdCategory>();
    public List<ProdMetaTag> prodMetaTags { get; set; } = new List<ProdMetaTag>();
    public List<Attribute> attributes { get; set; } = new List<Attribute>();
}