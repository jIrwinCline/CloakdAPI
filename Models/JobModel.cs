using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class JobModel
    {
        JobModel()
        {
            Id = new Guid();
            CreatedOn = DateTime.Now;
            IsCompleted = false;
        }
        [Required]
        public Guid Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public int BusinessId { get; set; }

        public int OfficerId { get; set; }

        [Required]
        public string ContactFName { get; set; }

        [Required]
        public string ContactLName { get; set; }

        [Required]
        public string ContactPhone { get; set; }

        [Required]
        public bool IsCompleted { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Duties { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Hours { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}