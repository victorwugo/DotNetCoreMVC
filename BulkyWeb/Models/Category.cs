using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models;

public class Category
{
    public int Id { get; set; }
    [Required]
    public String Name { get; set; }
    public int DisplayOrder { get; set; }
}
