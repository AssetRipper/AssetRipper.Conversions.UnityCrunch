using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.crnd::elemental_vector")]
public partial struct crnd_elemental_vector
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public int field_1;

	[FieldOffset(12)]
	public int field_2;
}
