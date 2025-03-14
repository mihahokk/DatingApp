﻿using System.Security.Claims;

namespace API.Extensions;

public static class ClaimPrincipleExtensions
{
    public static string GetUsername(this ClaimsPrincipal user)
    {
        var username = user.FindFirstValue(ClaimTypes.NameIdentifier) 
                       ?? throw new NullReferenceException("No username");

        return username;
    }
}