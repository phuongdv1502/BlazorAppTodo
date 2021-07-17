﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Api.Enums
{
    public enum Priority
    {
        Low,
        Medium,
        Hight
    }
    public enum Status
    {
        Open,
        Inprogress,
        Resolved,
        Done,
        Canceled,
        Closed
    }
}
