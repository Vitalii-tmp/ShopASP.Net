using System.ComponentModel.DataAnnotations;

namespace InternetStore.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Назва (заголовок)")]
        public virtual string? Title { get; set; }

        [Display(Name = "Короткий опис")]
        public virtual string? SubTitle { get; set; }

        [Display(Name = "Повний опис")]
        public virtual string? Text { get; set; }

        [Display(Name = "Титульна картинка")]
        public virtual string? TitleImagePath { get; set; }

        [Display(Name = "SEO метатег Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "SEO метатег Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "SEO метатег Keywords")]
        public string? MetaKeyWords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
