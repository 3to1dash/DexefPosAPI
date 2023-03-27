namespace DataAccess.Domain.FilesModels;

public class ReportDesignEntry
{
    public long Id { get; set; }

    public long? ParentId { get; set; }

    public long? SubId { get; set; }
}