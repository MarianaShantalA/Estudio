using System.ComponentModel.DataAnnotations;

namespace Estudio.Models
{
  
    public class Music
    {
        [Key]
        public int MusicId { get; set; }


        [Required(ErrorMessage = "El nombre de la cancion es requerido")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "El nombre tiene que tener entre 5 y 60 caracteres")]
        [Display(Name = "Nombre completo de la cancion")]
        public string Nombre { get; set; }


        [Required(ErrorMessage = "El nombre del autor es requerido")]
        [StringLength(60,MinimumLength = 5,ErrorMessage = "El nombre del autor tiene que tener entre 5 y 60 caracteres")]
       
        [Display(Name = "Nombre completo del autor")]
        public string Autor { get; set; }


        [Required(ErrorMessage = "Letra de la canciobn")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "El nombre tiene que tener entre 5 y 60 caracteres")]
        [Display(Name = "Letra de la cancion")]
        public string Letra { get; set; }


    }
}
