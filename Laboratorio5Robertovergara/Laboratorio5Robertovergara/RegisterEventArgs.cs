﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio5Robertovergara
{
    public class RegisterEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerificationLink { get; set; }
    }
}
