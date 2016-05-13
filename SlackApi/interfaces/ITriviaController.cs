using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackApi.interfaces
{
    public interface ITriviaController
    {
        event EventHandler<bool> UpdateTrivia;
        void PushUpdate(bool update);
    }

    public class TriviaController : ITriviaController
    {
        public event EventHandler<bool> UpdateTrivia = delegate { };
        public void PushUpdate(bool update)
        {
            UpdateTrivia?.Invoke(this, update);
        }
    }
}
