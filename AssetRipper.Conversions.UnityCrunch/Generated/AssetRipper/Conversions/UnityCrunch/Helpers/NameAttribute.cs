using System;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal abstract partial class NameAttribute(string name) : Attribute
{
	public string Name { get; } = name;
}
