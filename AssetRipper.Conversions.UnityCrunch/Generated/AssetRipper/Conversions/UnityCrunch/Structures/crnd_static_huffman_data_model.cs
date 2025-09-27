using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("class.crnd::static_huffman_data_model")]
[DemangledName("crnd::static_huffman_data_model")]
public partial struct crnd_static_huffman_data_model
{
	[FieldOffset(0)]
	public int m_total_syms;

	[FieldOffset(8)]
	public crnd_vector_f3cmzmc m_code_sizes;

	[FieldOffset(32)]
	public unsafe void* m_pDecode_tables;
}
