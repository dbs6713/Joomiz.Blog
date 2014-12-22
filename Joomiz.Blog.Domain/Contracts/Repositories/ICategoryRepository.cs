﻿using Joomiz.Blog.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Joomiz.Blog.Domain.Contracts.Repositories
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        IEnumerable<Category> GetByPostId(int postId);
    }
}
