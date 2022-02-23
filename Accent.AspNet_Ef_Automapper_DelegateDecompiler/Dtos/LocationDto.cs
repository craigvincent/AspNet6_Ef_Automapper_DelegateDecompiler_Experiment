namespace Accent.DotNetExperiments.Dtos
{
    public class LocationDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsFavorite { get; set; }
        public int OccupantCount { get; set; }
        public int DoubleOccupantCount { get; set; }
    }
}