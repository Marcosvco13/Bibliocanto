﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliocanto.Model.Models;
using Trab_AV2.Model.Repositories;

namespace Bibliocanto.Model.Repositories
{
    public class RepositoryPostagemBlog : RepositoryBase<PostagemBlog>
    {
        public RepositoryPostagemBlog(bool saveChanges = true) : base(saveChanges)
        { 
        }
    }
}
