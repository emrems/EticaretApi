public class Categories : BaseEntities
{
    public string Name { get; set; }
    public int ParentId { get; set; }
    public bool IsActive { get; set; }
    
}