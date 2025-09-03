public class OrderItems : BaseEntites
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public decimal UnitPrice { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "Quantity 0'dan buyuk olmalidir.")]
    public int Quantity { get; set; }

}