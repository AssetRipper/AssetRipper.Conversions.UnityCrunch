using System;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal partial class ExceptionInfo : IDisposable
{
	[ThreadStatic]
	public static ExceptionInfo? Current;

	public virtual string? GetMessage()
	{
		return null;
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	~ExceptionInfo()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
