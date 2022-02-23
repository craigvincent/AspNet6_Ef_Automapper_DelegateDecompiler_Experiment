using System.ComponentModel.DataAnnotations.Schema;
using DelegateDecompiler;

namespace Accent.DotNetExperiments.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsFavorite { get; set; }
        public int OccupantCount { get; set; }
        [NotMapped]
        [Computed]
        public int DoubleOccupantCount => OccupantCount * 2;
    }
}
