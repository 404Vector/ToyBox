using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBox.StdLib.IS
{
    public interface IExcutable
    {
        /// <summary>
        /// 해당 개체가 Excute 되었을 경우, 호출되는 Event.
        /// </summary>
        event ExcutedEventHandler Excuted;

        /// <summary>
        /// 해당 개체가 가지고 있는 관리 Action을 Excute하는 Methode
        /// </summary>
        void Excute();
    }
}