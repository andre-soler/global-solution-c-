namespace FutureOfWork.Api.Models
{
    public class Job
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string WorkMode { get; set; } = string.Empty;
    public string RequiredSkill { get; set; } = string.Empty;
    public decimal? SalaryFrom { get; set; }
    public decimal? SalaryTo { get; set; }

    public int? WorkerId { get; set; }
    public Worker? Worker { get; set; }
}
}