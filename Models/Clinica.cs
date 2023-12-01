using System.ComponentModel.DataAnnotations;
using BlazorApp1.Data;

namespace BlazorApp1.Models
{
    public class Clinica
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string  Medico { get; set; }

        [Required]
        [MaxLength(100)]
        public string Paciente { get; set; }

        [Required]
        [MaxLength(100)]
        public string Agendamento { get; set; }

        public Clinica()

        {

        }

        public Clinica(string Medico, string Paciente, string Agendamento, Guid id) 
        
        { 
            this.Medico = Medico;
            this.Paciente = Paciente;
            this.Agendamento = Agendamento;
            this.Id = id;
        }

        public void GenerateNewId()
        {
            Id = Guid.NewGuid();

        }


    }

   
}
