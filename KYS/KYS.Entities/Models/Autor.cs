using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KYS.Entities.Abstractions;

namespace KYS.Entities.Models
{
    public class Autor : BaseEntity
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? FullName => $"{Name} {SurName}";
        public string? Country { get; set; }
        public string? Image { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string? Biography { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
