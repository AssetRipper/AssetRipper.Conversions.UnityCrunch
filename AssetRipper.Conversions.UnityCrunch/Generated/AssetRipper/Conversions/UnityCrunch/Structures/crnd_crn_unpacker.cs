using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 392)]
[MangledName("class.crnd::crn_unpacker")]
public partial struct crnd_crn_unpacker
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public int field_2;

	[FieldOffset(24)]
	public unsafe void* field_3;

	[FieldOffset(32)]
	public crnd_symbol_codec field_4;

	[FieldOffset(72)]
	public crnd_static_huffman_data_model field_5;

	[FieldOffset(112)]
	public InlineArray_2_tahu2ya field_6;

	[FieldOffset(192)]
	public InlineArray_2_tahu2ya field_7;

	[FieldOffset(272)]
	public crnd_vector_5 field_8;

	[FieldOffset(296)]
	public crnd_vector_5 field_9;

	[FieldOffset(320)]
	public crnd_vector_8 field_10;

	[FieldOffset(344)]
	public crnd_vector_8 field_11;

	[FieldOffset(368)]
	public crnd_vector_11 field_12;
}
