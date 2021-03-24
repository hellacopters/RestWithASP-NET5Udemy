﻿using System.Collections.Generic;
using System.Security.Claims;

namespace RestWithASPNETUdemy.Services
{
    public interface ITokenService
    {
        string GenerateAcssesToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);

    }
}
