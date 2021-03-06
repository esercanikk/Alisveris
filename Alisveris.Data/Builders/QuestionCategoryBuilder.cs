﻿using Alisveris.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alisveris.Data.Builders
{
    public class QuestionCategoryBuilder
    {
        public QuestionCategoryBuilder(EntityTypeBuilder<QuestionCategory> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Name).IsRequired().HasMaxLength(200);


            builder.HasQueryFilter(b => !b.IsDeleted);
        }
    }
}
