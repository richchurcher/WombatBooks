using System.Collections.Generic;

namespace WombatBooks.Models
{
    public class BookResult
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public ICollection<Item> items { get; set; }
    }
}