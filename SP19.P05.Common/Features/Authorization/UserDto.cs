﻿using System.Collections.Generic;

namespace SP19.P05.Common.Features.Authorization
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<RoleDto> Roles { get; set; } = new List<RoleDto>();
    }
}