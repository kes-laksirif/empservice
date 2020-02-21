using System;

namespace empservice.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Password { get; set; }

        public bool PasswordChanged { get; set; }

        public bool ValidUser { get; set; }

        public string NewPassword { get; set; }

        public string Message { get; set; }

        public string Initials { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string Company { get; set; }

        public string SessionCode { get; set; }

        public DateTime SessionStartTime { get; set; }

        public DateTime SessionEndTime { get; set; }

        public bool ValidSession { get; set; }
    }
}