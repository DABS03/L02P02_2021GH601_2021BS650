﻿using System.ComponentModel.DataAnnotations;

namespace L02P02_2021GH601_2021BS650.Models
{
    public class pedido_encabezado
    {
        [Key]
        public int id { get; set; }
        public int id_cliente { get; set; }
        public int cantidad_libros { get; set; }
        public double total { get; set; }
    }
}
