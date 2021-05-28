using System;
using Dapper.Contrib.Extensions;

namespace hp_api.data.Models
{
    [Table("user")]
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}