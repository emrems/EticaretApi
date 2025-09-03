public class Products : BaseEntites
{
    public int Sku { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public decimal Price { get; set; }
    public int Stok { get; set; }
    public int CategoryId { get; set; }
    public bool IsActive { get; set; }

}