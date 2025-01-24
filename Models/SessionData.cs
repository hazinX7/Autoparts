using System.ComponentModel.DataAnnotations;

namespace autoparts.Models
{
    public class SessionData
    {
        [Key]
        public string Id { get; set; }
        public string Value { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
} 