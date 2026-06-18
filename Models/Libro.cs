using System.ComponentModel.DataAnnotations;

namespace T3_Espinoza_Diego.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El título del libro es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor del libro es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El tema del libro es obligatorio")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "La editorial del libro es obligatoria")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El año de publicación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año de publicación debe estar entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El número de páginas es obligatorio")]
        [Range(10, 1000, ErrorMessage = "Las páginas deben estar entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "La categoría del libro es obligatoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El material del libro es obligatorio")]
        public string Material { get; set; }

        [Required(ErrorMessage = "El número de copias es obligatorio")]
        [Range(1, 20, ErrorMessage = "Las copias deben estar entre 1 y 20")]
        public int Copias { get; set; }
    }
}