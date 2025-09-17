using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 104)]
[MangledName("struct.crnd::crn_file_info")]
public partial struct crnd_crn_file_info
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
	public InlineArray_16_vqkfj7a field_6;

	[FieldOffset(88)]
	public int field_7;

	[FieldOffset(92)]
	public int field_8;

	[FieldOffset(96)]
	public int field_9;

	[FieldOffset(100)]
	public int field_10;
}
