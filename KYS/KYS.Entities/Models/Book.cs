using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Book : BaseEntity
    {
        public string? Title { get; set; }           // Kitap Başlığı
        public string? ISBN { get; set; }            // ISBN Numarası
        public int PublishedYear { get; set; }       // Yayınlanma Yılı
        public string? Publisher { get; set; }       // Yayıncı Adı
        public int Pages { get; set; }               // Sayfa Sayısı
        public int CopiesAvailable { get; set; }     // Mevcut Kopya Sayısı
        public string? Description { get; set; }     // Kitap Açıklaması
        public string? Language { get; set; }        // Kitabın Dili
        public string? CoverImageUrl { get; set; }   // Kapak Resmi URL
        public bool AvailabilityStatus { get; set; } //True ise var False ise yok.
        // Navigation Property : Authoer
        public Guid AuthorID { get; set; }      // Yazar ID'si (Yabancı Anahtar)
        public string? AuthorName { get; set; } //Yazar Adı
        public Author? Author { get; set; }     // Yazar ile ilişki
        public string deneme { get; set; }

        // Navigation Property : Type
        public int TypeID { get; set; }             // Tür ID'si (Yabancı Anahtar)
        public string? TypeName { get; set; }       //Tür Name
        public BookType? BookType { get; set; }     // Tür ile ilişki

        // Navigation Property : BorrowRecord
        public ICollection<BorrowRecord>? BorrowRecord { get; set; } // Kitabın ödünç alma kayıtları

        // Navigation Property : Comment
        public ICollection<Comment>? Comments { get; set; } // Kitaba ait yorumlar

    }
}