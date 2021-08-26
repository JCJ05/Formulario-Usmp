using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Formulario_Usmp.Models
 {
    [Table("t_alumno")]
    public class Alumno
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
          public int Id { get; set; }
          
          [Column("nombres")]
          public String Nombres { get; set;}
          
          [Column("apellidos")]
          public String apellidos { get; set;}
          
          [Column("genero")]
          public String genero { get; set;}
          
          [Column("fechanacimiento")]
          public DateTime fecha { get; set;}
          
          [Column("dni")]
          public String dni { get; set;}
          
          [Column("carrera")]
          public String carrera {get; set;}

    }
}