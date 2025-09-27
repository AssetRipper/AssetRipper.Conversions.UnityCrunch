using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 104)]
[MangledName("struct.crnd::crn_file_info")]
[DemangledName("crnd::crn_file_info")]
public partial struct crnd_crn_file_info
{
	[FieldOffset(0)]
	public int m_struct_size;

	[FieldOffset(4)]
	public int m_actual_data_size;

	[FieldOffset(8)]
	public int m_header_size;

	[FieldOffset(12)]
	public int m_total_palette_size;

	[FieldOffset(16)]
	public int m_tables_size;

	[FieldOffset(20)]
	public int m_levels;

	[FieldOffset(24)]
	public InlineArray16_Int32 m_level_compressed_size;

	[FieldOffset(88)]
	public int m_color_endpoint_palette_entries;

	[FieldOffset(92)]
	public int m_color_selector_palette_entries;

	[FieldOffset(96)]
	public int m_alpha_endpoint_palette_entries;

	[FieldOffset(100)]
	public int m_alpha_selector_palette_entries;
}
