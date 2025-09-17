using System;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal sealed partial class FatalException : Exception
{
	public FatalException()
	{
	}

	public FatalException(string? message)
		: base(message)
	{
	}
}
