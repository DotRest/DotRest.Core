using System;
using System.Runtime.CompilerServices;

namespace DotRest
{
    /// <summary>
    /// Log interface.
    /// </summary>
	public interface ILog : IDisposable
	{
        /// <summary>
        /// Gets the log level filter.
        /// </summary>
		/// <value>Log level filter.</value>
		LogLevel Level
		{
			get;
		}

        /// <summary>
        /// Logs a trace message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Trace(string message, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a debug message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Debug(string message, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs an info message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Info(string message, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Warn(string message, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Error(string message, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="exception">Exception.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Error(string message, Exception exception, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a fatal error message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Fatal(string message, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

        /// <summary>
        /// Logs a fatal error message.
        /// </summary>
        /// <arg name="message">Message.</arg>
        /// <arg name="exception">Exception.</arg>
        /// <arg name="memberName">Caller member name (filled automatically).</arg>
        /// <arg name="filePath">Caller file name (filled automatically).</arg>
        /// <arg name="lineNumber">Caller line number (filled automatically).</arg>
		void Fatal(string message, Exception exception, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0);

	}
}
