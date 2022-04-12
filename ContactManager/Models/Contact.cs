using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
	public class Contact
	{
		public int ContactId { get; set; }

		[Required(ErrorMessage ="Required: First Name")]
		public string? fname { get; set; }

		[Required(ErrorMessage = "Required: Last Name")]
		public string? lname { get; set; }

		[Required(ErrorMessage = "Required: Phone Number")]
		public string? phone { get; set; }

		[Required(ErrorMessage = "Required: Email")]
		public string? email { get; set; }

		public string? organization { get; set; }

		public DateTime date_added { get; set; }

		[Required(ErrorMessage = "Required: Category")]
		public int? CategoryId { get; set; }

		public Category? category { get; set; }

        public string Slug => fname?.Replace(' ', '-').ToLower() + '-' + lname?.Replace(' ', '-').ToLower() + '-';


	}
}

