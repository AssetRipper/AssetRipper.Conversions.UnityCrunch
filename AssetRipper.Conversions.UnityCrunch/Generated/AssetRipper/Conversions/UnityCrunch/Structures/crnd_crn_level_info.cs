using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.crnd::crn_level_info")]
[DemangledName("crnd::crn_level_info")]
public partial struct crnd_crn_level_info
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(4)]
	public int field_1;

	[FieldOffset(8)]
	public int field_2;

	[FieldOffset(12)]
	public int field_3;

	[FieldOffset(16)]
	public int field_4;

	[FieldOffset(20)]
	public int field_5;

	[FieldOffset(24)]
	public int field_6;

	[FieldOffset(28)]
	public int field_7;
}
