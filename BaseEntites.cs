public abstract class BaseEntites
{
    public long Id { get; set; }                // Primary key
    public DateTime CreatedDate { get; set; }  // Oluşturulma tarihi
    public DateTime? UpdatedDate { get; set; } // Güncellenme tarihi (nullable)
    public bool IsDeleted { get; set; }        // Soft delete için
    public string? CreateUser { get; set; }    // Kaydı oluşturan kullanıcı
    public string? UpUser { get; set; }        // Güncelleyen kullanıcı
}