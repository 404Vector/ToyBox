using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBox.StdLib.IS
{
    public interface IAbortable
    {
        /// <summary>
        /// 해당 개체가 Abort 되었을 경우, 호출되는 Event.
        /// </summary>
        event AbortedEventHandler Aborted;

        /// <summary>
        /// 해당 개체가 가지고 있는 Action이 실행중일 경우, Abort하는 Methode
        /// </summary>
        void Abort();
    }
}