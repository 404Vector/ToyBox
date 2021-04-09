using System;

namespace HYCK.Base.StdL.IS
{
    public interface IDigitizer : IAbortable, IExcutable, IAllocatable, IDisposable
    {
        /// <summary>
        /// Grab하는 FPS.
        /// </summary>
        double? FPS { get; }

        /// <summary>
        /// 현재 Grab을 수행하고 있다면 True를 반환.
        /// </summary>
        bool IsWorking { get; }

        /// <summary>
        /// Grab을 수행할 때 마다 1씩 증가.
        /// </summary>
        long? GrabStackCount { get; }

        /// <summary>
        /// Grab을 수행할 횟수. value > 0일 경우 작동.
        /// </summary>
        long? ProcessCountEnd { get; }

        /// <summary>
        /// Grab을 수행한 횟수.
        /// </summary>
        long? ProcessCountNow { get; }

        /// <summary>
        /// 종속된 SystemID
        /// </summary>
        long? OwnerSystem { get; }

        /// <summary>
        /// Grab이 수행된 경우 호출됨.
        /// </summary>
        event GrabEvHandler Grabbed;
    }
}