using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBox.StdLib.IS
{
    public interface IISUnit : IDisposable, IAllocatable
    {
        /// <summary>
        /// 해당 개체가 Disposed 되었을 경우, True를 반환.
        /// </summary>
        bool IsDisposed { get; }

        /// <summary>
        /// Tracking을 위한 ID.
        /// </summary>
        long ContextID { get; }

        /// <summary>
        /// 해당 개체의 UnitType.
        /// </summary>
        ISUnitType ContextType { get; }

        /// <summary>
        /// 해당 개체가 Disposed 되었을 경우, 호출되는 Event.
        /// </summary>
        public event DisposedEventHandler Disposed;
    }
}