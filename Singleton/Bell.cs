using System;

namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public sealed class Bell
    {
        private static Bell _bellConnection;
        private static readonly object SyncRoot = new Object();
        private Bell()
        {

        }

        /// <summary>
        /// Потокобезопасная реализации паттерна
        /// </summary>
        public static Bell Instance
        {
            get
            {
                lock(SyncRoot)
                {
                    if(_bellConnection is null)
                    {
                        _bellConnection = new Bell();
                    }
                }

                return _bellConnection;
            }
        }

        /// <summary>
        /// Позвонить
        /// </summary>
        public void Ring()
        {
            Console.WriteLine("Din-don!");
        }
    }
}
