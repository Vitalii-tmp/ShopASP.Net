using System.ComponentModel.DataAnnotations;

namespace InternetStore.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;


        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Title")]
        public virtual string Title { get; set; }

        [Display(Name = "SubTitle")]
        public virtual string SubTitle { get; set; }

        [Display(Name = "Text")]
        public virtual string Text { get; set; }

        [Display(Name = "Image")]
        public virtual string TitleImagPath { get; set; }

        [Display(Name = "SEO MetaTag Title")]
        public virtual string MetaTitle { get; set; }
        
        [Display(Name = "SEO MetaTag Description")]
        public virtual string MetaDescription { get; set; }
        
        [Display(Name = "SEO MetaTag KeyWords")]
        public virtual string MetaKeyWords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

    }
}
