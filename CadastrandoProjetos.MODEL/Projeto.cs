using System;
using System.Collections.Generic;

namespace CadastrandoProjetos.MODEL;

public partial class Projeto
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Gerente { get; set; } = null!;

    public DateTime DataInicio { get; set; }

    public DateTime? DataFinal { get; set; }

    public string Resumo { get; set; } = null!;

    public string Status { get; set; } = null!;
}
