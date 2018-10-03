namespace FFTApp.UI.ViewModels.Models.PartProductionDB
{
    public interface ISoftware
    {
        string Description { get; set; }
        string Name { get; set; }
        int? ParentSoftwareId { get; set; }
        string Path { get; set; }
        int? ProductionCategoryId { get; set; }
        int? ProductionSystemNumberId { get; set; }
        int? SoftwareId { get; set; }
    }
}