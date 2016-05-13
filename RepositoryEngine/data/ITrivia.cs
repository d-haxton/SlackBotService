using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public interface ITrivia
    {
        string Question { get; set; }
        string Answer { get; set; }
        int Points { get; set; }
        string HintOne { get; set; }
        string HintTwo { get; set; }
        string HintThree { get; set; }
    }
}
