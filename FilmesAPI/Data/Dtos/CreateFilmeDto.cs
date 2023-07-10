using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O título do filme não pode exceder 50 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage = "O gênero do filme não pode exceder 50 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo de duração é obrigatório")]
        [Range(70, 600, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 360")]
        public int Duracao { get; set; }
    }
}
