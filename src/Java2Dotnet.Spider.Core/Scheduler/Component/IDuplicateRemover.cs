using System;
using System.Runtime.CompilerServices;

namespace Java2Dotnet.Spider.Core.Scheduler.Component
{
	/// <summary>
	/// Remove duplicate requests.
	/// </summary>
	public interface IDuplicateRemover : IDisposable
	{
		/// <summary>
		/// Check whether the request is duplicate.
		/// </summary>
		/// <param name="request"></param>
		/// <param name="spider"></param>
		/// <returns></returns>
		bool IsDuplicate(Request request);

		/// <summary>
		/// Reset duplicate check.
		/// </summary>
		/// <param name="spider"></param>
		void ResetDuplicateCheck();

		/// <summary>
		/// Get TotalRequestsCount for monitor.
		/// </summary>
		/// <param name="spider"></param>
		/// <returns></returns>
		long GetTotalRequestsCount();
	}
}
