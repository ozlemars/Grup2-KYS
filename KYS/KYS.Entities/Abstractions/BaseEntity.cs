namespace KYS.Entities.Abstractions
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime UpdatedDate { get; set; }

    }

    public class Duyurular : BaseEntity
    {
        public string Baslik { get; set; } // Duyuru başlığı
        public string Icerik { get; set; } // Duyuru içeriği
        public DateTime YayınTarihi { get; set; } // Yayınlanma tarihi
    }
}
