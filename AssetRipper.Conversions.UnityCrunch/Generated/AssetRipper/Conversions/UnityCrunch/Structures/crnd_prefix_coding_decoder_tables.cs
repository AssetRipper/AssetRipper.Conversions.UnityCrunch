using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 192)]
[MangledName("class.crnd::prefix_coding::decoder_tables")]
public partial struct crnd_prefix_coding_decoder_tables
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
	public sbyte field_6;

	[FieldOffset(25)]
	public sbyte field_7;

	[FieldOffset(28)]
	public InlineArray_17_vqkfj7a field_8;

	[FieldOffset(96)]
	public InlineArray_17_vqkfj7a field_9;

	[FieldOffset(164)]
	public int field_10;

	[FieldOffset(168)]
	public unsafe void* field_11;

	[FieldOffset(176)]
	public int field_12;

	[FieldOffset(184)]
	public unsafe void* field_13;
}
