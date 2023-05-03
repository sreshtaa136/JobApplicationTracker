using System;
#nullable enable

// layout for applications
namespace ApplicationTracker.Models
{
	public class Application
	{
        public Application() {}

        // properties that each application will have
		public int Id { get; set; }
        public string? AppliedOn { get; set; }
        public string? Company { get; set; }
        public string? Role { get; set; }
        public string? Location { get; set; }
        public string? Status { get; set; }
        public bool Referral { get; set; }
        public string? Url { get; set; }
    }
}

