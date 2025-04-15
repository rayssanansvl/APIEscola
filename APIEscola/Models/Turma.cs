using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; }
        [Required(ErrorMessage = "A Data de Inicio é Obrigatória!")]
        [DataType(DataType.Date, ErrorMessage = "O Formato da Data não é Valido.")]
        public DateOnly DataInicio { get; set; }
        [Required(ErrorMessage = "A Data de Fim é Obrigatória!")]
        [DataType(DataType.Date, ErrorMessage = "O Formato da Data não é Valido.")]
        public DateOnly DataFim { get; set; }
        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")]
        [MaxLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")]
        public string? Sigla { get; set; }
        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")]
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 255 caracteres")]
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "O Campo Curso é Obrigatório")]
        public Guid CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}