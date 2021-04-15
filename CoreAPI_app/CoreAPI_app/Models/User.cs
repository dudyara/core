﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreAPI_app.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя пользователя")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Возраст должен быть в промежутке от 1 до 100")]
        [Required(ErrorMessage = "Укажите возраст пользователя")]
        public int Age { get; set; }
    }
}
