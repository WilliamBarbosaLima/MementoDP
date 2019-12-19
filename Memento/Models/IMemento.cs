﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Models
{
    // The Memento interface provides a way to retrieve the memento's metadata,
    // such as creation date or name. However, it doesn't expose the
    // Originator's state.
    interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
