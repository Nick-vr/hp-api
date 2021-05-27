using System;
using Dapper.Contrib.Extensions;

namespace hp_api.data.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}