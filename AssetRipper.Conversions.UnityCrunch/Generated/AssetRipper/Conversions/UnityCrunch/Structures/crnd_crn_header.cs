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
	public crnd_crn_packed_uint_hnsywfd m_sig;

	[FieldOffset(2)]
	public crnd_crn_packed_uint_hnsywfd m_header_size;

	[FieldOffset(4)]
	public crnd_crn_packed_uint_hnsywfd m_header_crc16;

	[FieldOffset(6)]
	public crnd_crn_packed_uint_jymcebc m_data_size;

	[FieldOffset(10)]
	public crnd_crn_packed_uint_hnsywfd m_data_crc16;

	[FieldOffset(12)]
	public crnd_crn_packed_uint_hnsywfd m_width;

	[FieldOffset(14)]
	public crnd_crn_packed_uint_hnsywfd m_height;

	[FieldOffset(16)]
	public crnd_crn_packed_uint_94amu2d m_levels;

	[FieldOffset(17)]
	public crnd_crn_packed_uint_94amu2d m_faces;

	[FieldOffset(18)]
	public crnd_crn_packed_uint_94amu2d m_format;

	[FieldOffset(19)]
	public crnd_crn_packed_uint_hnsywfd m_flags;

	[FieldOffset(21)]
	public crnd_crn_packed_uint_jymcebc m_reserved;

	[FieldOffset(25)]
	public crnd_crn_packed_uint_jymcebc m_userdata0;

	[FieldOffset(29)]
	public crnd_crn_packed_uint_jymcebc m_userdata1;

	[FieldOffset(33)]
	public crnd_crn_palette m_color_endpoints;

	[FieldOffset(41)]
	public crnd_crn_palette m_color_selectors;

	[FieldOffset(49)]
	public crnd_crn_palette m_alpha_endpoints;

	[FieldOffset(57)]
	public crnd_crn_palette m_alpha_selectors;

	[FieldOffset(65)]
	public crnd_crn_packed_uint_hnsywfd m_tables_size;

	[FieldOffset(67)]
	public crnd_crn_packed_uint_fru7ewb m_tables_ofs;

	[FieldOffset(70)]
	public InlineArray1_crnd_crn_packed_uint_jymcebc m_level_ofs;
}
