﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentiaks(SecurityKey security)
        {
            return new SigningCredentials(security, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
