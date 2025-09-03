public class Orders : BaseEntites
{
    public string OrderNo { get; set; }
    public int UserId { get; set; }
    public decimal Total { get; set; }
    public string Status { get; set; }
    public DateTime? PaidAt { get; set; }

}