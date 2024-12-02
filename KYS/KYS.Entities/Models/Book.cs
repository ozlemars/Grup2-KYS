using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Book: BaseEntity
    {
        public string? BookName { get; set; }
        public string? Publisher { get; set; }
        public int PublicationYear { get; set; }
        public string? ISBN { get; set; }
        public int PageCount { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Stock { get; set; }
        public BookStatus? Status { get; set; }
        public DateTime? ReservedDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public Guid CategoryID { get; set; }
        public Guid AutorID { get; set; }

        public Category? Category { get; set; }
        public Autor? Autor { get; set; }
    }

    public enum BookStatus
    {
        Available,  // Mevcut
        Borrowed,   // Ödünç alınmış
        Reserved,   // Rezerve edilmiş
        Lost        // Kaybolmuş
    }
}
