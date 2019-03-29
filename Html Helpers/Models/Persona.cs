using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Html_Helpers.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Inserte su cedula")]
        public int Cedula { get; set; }

        [Required(ErrorMessage ="Inserte su nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Inserte su apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Inserte su edad, su edad debe ser mayor que 15")]
        [Range(15, 100)]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Inserte su numero de telefono")]
        public int Telefono { get; set; }

    
        [Required(ErrorMessage = "Inserte su correo electronico")]
        [EmailAddressAttribute]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Seleccione una opcion")]
        public Genero genero { get; set; } 

        [Required(ErrorMessage = "Seleccione una opcion")]
        public string Estado { get; set; }

        
        public List<ModelCheckBox> Hobby { get; set; }



    }
    public enum Genero
    {
        M,
        F
    }
}