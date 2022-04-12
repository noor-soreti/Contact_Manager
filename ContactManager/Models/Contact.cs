using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactManager.Models
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }

		[Required]
		public string? fname { get; set; }

		[Required]
		public string? lname { get; set; }

		[Required]
		public string? phone { get; set; }

		[Required]
		public string? email { get; set; }

		[Required]
		public string? organization { get; set; }

		public DateTime date_added { get; set; }

		[Required]
		public int? CategoryId { get; set; }

		//[ForeignKey("CategoryId")]
		public Category? category { get; set; }

        public string Slug => fname?.Replace(' ', '-').ToLower() + '-' + lname?.Replace(' ', '-').ToLower() + '-';


	}
}

