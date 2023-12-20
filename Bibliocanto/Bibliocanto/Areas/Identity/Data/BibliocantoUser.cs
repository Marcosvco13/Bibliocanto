﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Bibliocanto.Areas.Identity.Data;

// Add profile data for application users by adding properties to the BibliocantoUser class
public class BibliocantoUser : IdentityUser
{
    [MaxLength(50, ErrorMessage = "O tamanho máximo do campo {0} é de {1} caracteres")]
    [Required]
    public string Name { get; set; }
}

