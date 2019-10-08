using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC5_01.Models
{
    public class PhoneCatalog
    {
        public PhoneCatalog()
        {
        }

        public PhoneCatalog(string surname, string firstName, string middlename, DateTime bDay, string phone)
        {
            Surname = surname;
            FirstName = firstName;
            Middlename = middlename;
            BDay = bDay;
            PhoneNumber = phone;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(30, ErrorMessage = "Длина не может превышать 30 символов")]
        public string Surname { get; set; }

        [Display(Name = "Имя")]
        [StringLength(30, ErrorMessage = "Длина не может превышать 30 символов")]
        public string FirstName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(30, ErrorMessage = "Длина не может превышать 30 символов")]
        public string Middlename { get; set; }

        [Display(Name = "Дата рождения")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BDay { get; set; }

        [Display(Name = "Телефон")]
        [StringLength(15, ErrorMessage = "Длина не может превышать 15 символов")]
        public string PhoneNumber { get; set; }

    }
}