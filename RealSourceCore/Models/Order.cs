using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Collections.Generic;
namespace RealSourceCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OrderedDate { get; set; }
        public DateTime AcceptedDate { get; set; }
        public DateTime DeliveredDate { get; set; }
        public int OrderStatus { get; set; }
        public decimal Price { get; set; }
        public int Duration { get; set; }   
        public string CustomerId { get; set; }
        public string WriterId { get; set; }

        public string AppUserId { get; set; }
        [ForeignKey("AppUserId")]
        public virtual ApplicationUser User { get; set; }
        public string CustomerName { get; set; }
        public string AcademicLevel { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount must be greater than 0!")]
        public int NoPages { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        [DisplayName("Course/Module Name")]
        public string ModuleName { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        [DisplayName("Institution Name")]
        public string InstitutionName { get; set; }
        public string FileAttached { get; set; }
     
        [Required]
        public string Instructions { get; set; }
    }
}
