using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.crnd::vector")]
public partial struct crnd_vector
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public int field_1;

	[FieldOffset(12)]
	public int field_2;

	[FieldOffset(16)]
	public sbyte field_3;
}
