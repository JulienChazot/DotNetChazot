namespace newWebAPI.Models
{
    public class BaseModel
    {
        // created at 
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // updated at
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        // deleted at
        public DateTime DeletedAt { get; set; } = DateTime.Now;
        // created by
        public string CreatedBy { get; set; } = String.Empty;

        // updated by
        public string UpdatedBy { get; set; } = String.Empty;
    }
}