using System.Collections.Generic;

namespace WombatBooks.Models
{
    public class VolumeInfo
    {
        public string title { get; set; }
        public ICollection<string> authors { get; set; }
    }
}