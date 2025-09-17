using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.crnd::crn_palette")]
public partial struct crnd_crn_palette
{
	[FieldOffset(0)]
	public crnd_crn_packed_uint_2 field_0;

	[FieldOffset(3)]
	public crnd_crn_packed_uint_2 field_1;

	[FieldOffset(6)]
	public crnd_crn_packed_uint field_2;
}
