using System.Collections.Generic;

namespace WombatBooks.Models
{
    public class BookResult
    {
        public string kind { get; set; }
        public int totalItems { get; set; }
        public ICollection<Item> items { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string id { get; set; }
        public string etag { get; set; }
        public string selfLink { get; set; }
        public VolumeInfo volumeInfo { get; set; }
    }

    public class VolumeInfo
    {
        public string title { get; set; }
        public ICollection<string> authors { get; set; }
    }
}