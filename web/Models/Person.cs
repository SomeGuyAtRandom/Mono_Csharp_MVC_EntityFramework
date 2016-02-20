using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace web.Models
{
	public class PersonConfig
	{
		[Display(Name = "Birthday")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime? BirthDate { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		public string LastName { get; set; }

	}


	[MetadataType(typeof(PersonConfig))]
	[Table("people")]
	public class Person
	{
		public Person (){ }

		[Column("id")]
		public int Id { get; set; }

		[Column("first_name")]
		[Required(ErrorMessage = "First name is required")]
		public string FirstName { get; set; }

		[Column("last_name")]
		[Required(ErrorMessage = "Last name is required")]
		public string LastName { get; set; }

		[Column("birth_date")]
		public DateTime? BirthDate { get; set; }
	}
}

