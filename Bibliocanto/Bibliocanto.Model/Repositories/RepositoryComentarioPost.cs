﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliocanto.Model.Models;
using Trab_AV2.Model.Repositories;

namespace Bibliocanto.Model.Repositories
{
    public class RepositoryComentarioPost : RepositoryBase<ComentarioPost>
    {
        public RepositoryComentarioPost(bool saveChanges = true) : base(saveChanges) 
        { 
        }
    }
}
