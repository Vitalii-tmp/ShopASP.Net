using System.ComponentModel.DataAnnotations;

namespace InternetStore.Models
{
    public class Adress
    {
        [Key] 
        public string? City { get; set;  }
    }
}
