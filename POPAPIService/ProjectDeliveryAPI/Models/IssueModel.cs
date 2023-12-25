namespace ProjectDeliveryAPI.Models
{
    public class IssueModel
    {
        public int IssueId { get; set; }
        public string Subject { get; set; }
        public string IssueBy { get; set; }
        public string Status { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
