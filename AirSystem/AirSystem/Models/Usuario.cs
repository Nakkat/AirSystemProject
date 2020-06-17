using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

public class Usuario
{
    public int ID { get; set; }
    public string nome { get; set; }
    public string sobrenome { get; set; }
    public string endereco { get; set; }
    public string numero { get; set; }

    [DataType(DataType.Date)]
    public DateTime dataNascimento { get; set; }

    public bool tipoUsuario { get; set; }
    public string usuario { get; set; }

    [DataType(DataType.Password)]
    public string senha { get; set; }
}


