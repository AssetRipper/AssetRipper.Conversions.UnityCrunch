using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("class.crnd::symbol_codec")]
[DemangledName("crnd::symbol_codec")]
public partial struct crnd_symbol_codec
{
	[FieldOffset(0)]
	public unsafe void* m_pDecode_buf;

	[FieldOffset(8)]
	public unsafe void* m_pDecode_buf_next;

	[FieldOffset(16)]
	public unsafe void* m_pDecode_buf_end;

	[FieldOffset(24)]
	public int m_decode_buf_size;

	[FieldOffset(28)]
	public int m_bit_buf;

	[FieldOffset(32)]
	public int m_bit_count;
}
