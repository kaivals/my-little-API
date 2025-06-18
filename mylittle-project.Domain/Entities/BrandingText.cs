namespace mylittle_project.Domain.Entities
{
    public class BrandingText
    {
        public Guid Id { get; set; }
        public string FontName { get; set; } = string.Empty;
        public string FontSize { get; set; } = string.Empty;
        public string FontWeight { get; set; } = string.Empty;
    }
}