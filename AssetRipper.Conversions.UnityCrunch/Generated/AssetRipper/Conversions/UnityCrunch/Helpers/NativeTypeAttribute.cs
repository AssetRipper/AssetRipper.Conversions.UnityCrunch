using System;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

[AttributeUsage(AttributeTargets.All)]
internal sealed partial class NativeTypeAttribute : NameAttribute
{
	public NativeTypeAttribute(string name)
		: base(name)
	{
	}
}
