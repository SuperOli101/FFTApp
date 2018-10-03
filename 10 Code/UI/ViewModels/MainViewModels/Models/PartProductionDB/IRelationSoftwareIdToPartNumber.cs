namespace FFTApp.UI.ViewModels.Models.PartProductionDB
{
    public interface IRelationSoftwareIdToPartNumber
    {
        string PartNumber { get; set; }
        int SoftwareId { get; set; }
    }
}