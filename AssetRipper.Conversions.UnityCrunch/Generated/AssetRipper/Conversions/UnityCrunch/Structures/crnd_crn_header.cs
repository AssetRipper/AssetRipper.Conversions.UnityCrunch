using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 74)]
[MangledName("struct.crnd::crn_header")]
[DemangledName("crnd::crn_header")]
public partial struct crnd_crn_header
{
	[FieldOffset(0)]
	public crnd_crn_packed_uint_hnsywfd field_0;

	[FieldOffset(2)]
	public crnd_crn_packed_uint_hnsywfd field_1;

	[FieldOffset(4)]
	public crnd_crn_packed_uint_hnsywfd field_2;

	[FieldOffset(6)]
	public crnd_crn_packed_uint_jymcebc field_3;

	[FieldOffset(10)]
	public crnd_crn_packed_uint_hnsywfd field_4;

	[FieldOffset(12)]
	public crnd_crn_packed_uint_hnsywfd field_5;

	[FieldOffset(14)]
	public crnd_crn_packed_uint_hnsywfd field_6;

	[FieldOffset(16)]
	public crnd_crn_packed_uint_94amu2d field_7;

	[FieldOffset(17)]
	public crnd_crn_packed_uint_94amu2d field_8;

	[FieldOffset(18)]
	public crnd_crn_packed_uint_94amu2d field_9;

	[FieldOffset(19)]
	public crnd_crn_packed_uint_hnsywfd field_10;

	[FieldOffset(21)]
	public crnd_crn_packed_uint_jymcebc field_11;

	[FieldOffset(25)]
	public crnd_crn_packed_uint_jymcebc field_12;

	[FieldOffset(29)]
	public crnd_crn_packed_uint_jymcebc field_13;

	[FieldOffset(33)]
	public crnd_crn_palette field_14;

	[FieldOffset(41)]
	public crnd_crn_palette field_15;

	[FieldOffset(49)]
	public crnd_crn_palette field_16;

	[FieldOffset(57)]
	public crnd_crn_palette field_17;

	[FieldOffset(65)]
	public crnd_crn_packed_uint_hnsywfd field_18;

	[FieldOffset(67)]
	public crnd_crn_packed_uint_fru7ewb field_19;

	[FieldOffset(70)]
	public InlineArray1_crnd_crn_packed_uint_jymcebc field_20;
}
