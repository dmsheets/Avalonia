using System;

namespace Avalonia.Controls
{
    /// <summary>
    /// Sends events about the application lifecycle.
    /// </summary>
    public interface IApplicationLifecycle
    {
        /// <summary>
        /// Sent when the application is starting up.
        /// </summary>
        event EventHandler<StartupEventArgs> Startup;

        /// <summary>
        /// Sent when the application is exiting.
        /// </summary>
        event EventHandler<ExitEventArgs> Exit;

        /// <summary>
        /// Shuts down the application and sets the exit code that is returned to the operating system when the application exits.
        /// </summary>
        /// <param name="exitCode">An integer exit code for an application. The default exit code is 0.</param>
        void Shutdown(int exitCode = 0);
    }
}
