using System.ComponentModel.DataAnnotations;

namespace InternetStore.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Заголовок")] 
        public override string Title { get; set; } = "Контакти";

        [Display(Name = "Вміст сторінки")]      
        public override string Text { get; set; } = "Вміст заповнюється адміністратором";


    }
}
