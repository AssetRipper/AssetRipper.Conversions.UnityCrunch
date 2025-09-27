using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 392)]
[MangledName("class.crnd::crn_unpacker")]
[DemangledName("crnd::crn_unpacker")]
public partial struct crnd_crn_unpacker
{
	[FieldOffset(0)]
	public int m_magic;

	[FieldOffset(8)]
	public unsafe void* m_pData;

	[FieldOffset(16)]
	public int m_data_size;

	[FieldOffset(24)]
	public unsafe void* m_pHeader;

	[FieldOffset(32)]
	public crnd_symbol_codec m_codec;

	[FieldOffset(72)]
	public crnd_static_huffman_data_model m_reference_encoding_dm;

	[FieldOffset(112)]
	public InlineArray2_crnd_static_huffman_data_model m_endpoint_delta_dm;

	[FieldOffset(192)]
	public InlineArray2_crnd_static_huffman_data_model m_selector_delta_dm;

	[FieldOffset(272)]
	public crnd_vector_maaktjc m_color_endpoints;

	[FieldOffset(296)]
	public crnd_vector_maaktjc m_color_selectors;

	[FieldOffset(320)]
	public crnd_vector_rf9iywd m_alpha_endpoints;

	[FieldOffset(344)]
	public crnd_vector_rf9iywd m_alpha_selectors;

	[FieldOffset(368)]
	public crnd_vector_y4ukjxd m_block_buffer;
}
