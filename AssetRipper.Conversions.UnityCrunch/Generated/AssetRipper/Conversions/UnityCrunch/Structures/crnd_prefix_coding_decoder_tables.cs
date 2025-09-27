using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 192)]
[MangledName("class.crnd::prefix_coding::decoder_tables")]
[DemangledName("crnd::prefix_coding::decoder_tables")]
public partial struct crnd_prefix_coding_decoder_tables
{
	[FieldOffset(0)]
	public int m_num_syms;

	[FieldOffset(4)]
	public int m_total_used_syms;

	[FieldOffset(8)]
	public int m_table_bits;

	[FieldOffset(12)]
	public int m_table_shift;

	[FieldOffset(16)]
	public int m_table_max_code;

	[FieldOffset(20)]
	public int m_decode_start_code_size;

	[FieldOffset(24)]
	public sbyte m_min_code_size;

	[FieldOffset(25)]
	public sbyte m_max_code_size;

	[FieldOffset(28)]
	public InlineArray17_Int32 m_max_codes;

	[FieldOffset(96)]
	public InlineArray17_Int32 m_val_ptrs;

	[FieldOffset(164)]
	public int m_cur_lookup_size;

	[FieldOffset(168)]
	public unsafe void* m_lookup;

	[FieldOffset(176)]
	public int m_cur_sorted_symbol_order_size;

	[FieldOffset(184)]
	public unsafe void* m_sorted_symbol_order;
}
