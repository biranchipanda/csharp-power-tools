namespace CSharpPowerTools.DesignPatterns
{
    using System;

    // The basic idea is by inheriting from this class, the child class becomes Singleton.
    // This implementation currently exposes and static GetInstance method which would
    // return the instance of the class using double lock checking mechanism.
    // TODO:
    //    Figure out a way to ensure that the derived class has no public constructor
    //    and make activator work with that.
    public abstract class Singleton<T> where T : new()
    {
        private static T _instance;

        private static object mutex = new object();

        public static T GetInstance()
        {
            // Double lock checking mechanism
            if (_instance == null)
            {
                lock (mutex)
                {
                    if (_instance == null)
                    {
                        _instance = new T(); // Activator.CreateInstance<T>();
                    }
                }
            }

            return _instance;
        }
    }
}