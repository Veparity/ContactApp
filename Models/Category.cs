// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.ComponentModel.DataAnnotations;

namespace ContactApp.Models
{
    public class Category
    { //Primary Key
        public int Id { get; set; }

        [Required]
        public string? AppUserId { get; set; }

        [Required]
        [Display(Name= "Category Name")]
        public string? Name { get; set; }

        //Navigation Properties

        public virtual AppUser? AppUser { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }= new HashSet<Contact>();
        
    }
}
