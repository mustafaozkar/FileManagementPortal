﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OperationClaim : BaseEntity,IEntity
    {
        public string Name { get; set; }
    }
}
