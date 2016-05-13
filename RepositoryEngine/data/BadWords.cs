using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEngine.data
{
    public class BadWords : IBadWords
    {
        public string Word { get; set; }
        public EBadWord Action { get; set; }
        public Guid Id { get; set; }
    }

    public enum EBadWord
    {
        Warn,
        Remove,
        Flag
    }
}
