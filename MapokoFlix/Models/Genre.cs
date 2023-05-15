using  System.ComponentModel.DataAnnotations;

namespace MapokoFlix.Models;
    public class Genre
    {
        [Key ] // É uma notação para chave primária 
        public byte Id { get; set; }

        [Required] // Requerido - Not Null no banco ; Torna o nome obrigatório
        [StringLength(30)]  //Tamanho máximo da propriedade 
        public string Name { get; set; }
    }
