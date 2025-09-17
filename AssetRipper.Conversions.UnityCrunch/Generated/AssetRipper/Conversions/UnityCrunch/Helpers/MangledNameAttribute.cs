using System;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
internal sealed partial class MangledNameAttribute : NameAttribute
{
	public MangledNameAttribute(string name)
		: base(name)
	{
	}
}
