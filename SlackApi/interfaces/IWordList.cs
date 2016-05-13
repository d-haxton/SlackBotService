﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackApi.interfaces
{
    public interface IWordList
    {
        List<string> BannedWords { get; }
        List<string> WarnedWords { get; }
        List<string> WhitelistedWords { get; }   
    }
}
