﻿using System.ComponentModel.DataAnnotations;

namespace L02P02_2021GH601_2021BS650.Models
{
    public class comentarios_libros
    {
        [Key]
        public int id { get; set; }
        public int id_libro {  get; set; }

        public string comentarios {  get; set; }
        public string usuario { get; set; }
        public DateTime created_at { get; set; }
    }
}
