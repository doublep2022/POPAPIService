namespace SaleFunnelAPI.Models
{
    public class LeadModel
    {
        public int LeadId { get; set; }
        public string? LeadProjectName { get; set; }
        public string? Customer { get; set; }
        public string? Status { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
