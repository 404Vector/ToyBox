namespace ToyBox.StdLib.IS
{
    public interface IAllocatable
    {
        /// <summary>
        /// 해당 개체가 Allocated 되었을 경우, True를 반환.
        /// </summary>
        bool IsAllocated { get; }

        /// <summary>
        /// 해당 개체가 Allocated 되었을 경우, 호출되는 Event.
        /// </summary>
        event AllocatedEventHandler Allocated;

        /// <summary>
        /// 해당 개체가 가지고 있는 관리 & 비관리형 데이터를 Alloc하는 Method.
        /// </summary>
        void Allocate();
    }
}