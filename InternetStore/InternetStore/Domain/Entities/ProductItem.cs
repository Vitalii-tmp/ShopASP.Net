﻿using System.ComponentModel.DataAnnotations;

namespace InternetStore.Domain.Entities
{
    public class ProductItem : EntityBase
    {
        [Required(ErrorMessage = "Заповніть назву товару")]
        [Display(Name = "Назва продукту")]
        public override string Title { get; set; } = "Контакти";

        [Display(Name = "Коротки опис товару")]
        public override string SubTitle { get; set; } = "Вміст заповнюється адміністратором";

        [Display(Name = "Повний опис товару")]
        public override string Text { get; set; } = "Вміст заповнюється адміністратором";
    }
}
