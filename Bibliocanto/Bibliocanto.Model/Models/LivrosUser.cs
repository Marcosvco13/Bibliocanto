﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Bibliocanto.Model.Models;

public partial class LivrosUser
{
    public int Id { get; set; }

    public string IdUser { get; set; }

    public string Nome { get; set; }

    public string Autor { get; set; }

    public int? Lido { get; set; }

    public string Comentario { get; set; }

    public int? Genero { get; set; }

    public byte[] Capa { get; set; }
}