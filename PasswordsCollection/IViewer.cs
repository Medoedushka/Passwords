﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordsCollection
{
    interface IViewer
    {
        event EventHandler<EventArgs> CreateNewPas;
    }
}