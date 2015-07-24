namespace CSharpPowerTools.Common
{
    using System;

    public static class ApplicationInfra
    {
        public static readonly AppDomain CurrentAppDomain = AppDomain.CurrentDomain;

        /// <summary>
        /// Provides and ASP.NET / WPF type global handler for unhandled exceptions that can be used with Console applications.
        /// This will help to achieve graceful teardown of resources for unhandled exceptions.
        /// Currently this will aimed to work with single AppDomain.
        /// </summary>
        /// <param name="onException">Action on run on exception.</param>
        /// <param name="afterException">Action to run after exception is handled and before app exits.</param>
        public static void OnUnhandledException(Action<Exception> onException, Action afterException = null)
        {
            CurrentAppDomain.UnhandledException += (s, e) =>
            {
                var ex = (Exception)e.ExceptionObject;
                onException(ex);

                if (afterException != null)
                {
                    afterException();
                }

                System.Environment.Exit(0);
            };
        }
    }
}