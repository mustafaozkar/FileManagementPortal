﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class AuthenticatedDto : IDto
    {
        public string UserNickName { get; set; }
        public string UserEmail { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
