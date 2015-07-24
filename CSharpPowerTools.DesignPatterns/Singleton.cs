namespace CSharpPowerTools.DesignPatterns
{
    using System;

    public abstract class Singleton<T> where T : new()
    {
        protected static T Instance;

        public static T GetInstance()
        {
            if (Instance == null)
            {
                Instance = Activator.CreateInstance<T>();
            }

            return Instance;
        }
    }
}