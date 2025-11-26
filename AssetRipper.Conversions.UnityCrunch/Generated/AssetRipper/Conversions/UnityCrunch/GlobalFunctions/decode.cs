using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode@symbol_codec@crnd@@QEAAIAEBVstatic_huffman_data_model@2@@Z")]
[DemangledName("public: unsigned int __cdecl crnd::symbol_codec::decode(class crnd::static_huffman_data_model const &)")]
internal static partial class decode
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("class crnd::static_huffman_data_model const &")] void* model)
	{
		unchecked
		{
			void* pDecode_tables = ((crnd_static_huffman_data_model*)model)->m_pDecode_tables;
			if (((crnd_symbol_codec*)@this)->m_bit_count < 24)
			{
				if (((crnd_symbol_codec*)@this)->m_bit_count < 16)
				{
					int num = 0;
					int num2 = 0;
					void* ptr = ((crnd_symbol_codec*)@this)->m_pDecode_buf_next;
					if (ptr < ((crnd_symbol_codec*)@this)->m_pDecode_buf_end)
					{
						void* ptr2 = ptr;
						ptr = (byte*)ptr2 + 1;
						num = (byte)(*(sbyte*)ptr2);
					}
					if (ptr < ((crnd_symbol_codec*)@this)->m_pDecode_buf_end)
					{
						void* ptr3 = ptr;
						ptr = (byte*)ptr3 + 1;
						num2 = (byte)(*(sbyte*)ptr3);
					}
					((crnd_symbol_codec*)@this)->m_pDecode_buf_next = ptr;
					int num3;
					checked
					{
						unchecked((crnd_symbol_codec*)@this)->m_bit_count += 16;
						num3 = ((num << 8) | num2) << 32 - unchecked((crnd_symbol_codec*)@this)->m_bit_count;
					}
					((crnd_symbol_codec*)@this)->m_bit_buf |= num3;
				}
				else
				{
					int num4;
					if (((crnd_symbol_codec*)@this)->m_pDecode_buf_next < ((crnd_symbol_codec*)@this)->m_pDecode_buf_end)
					{
						void** pDecode_buf_next = &((crnd_symbol_codec*)@this)->m_pDecode_buf_next;
						void* ptr4 = *pDecode_buf_next;
						*pDecode_buf_next = (byte*)ptr4 + 1;
						num4 = (byte)(*(sbyte*)ptr4);
					}
					else
					{
						num4 = 0;
					}
					int num5 = num4;
					int num6;
					checked
					{
						unchecked((crnd_symbol_codec*)@this)->m_bit_count += 8;
						num6 = num5 << 32 - unchecked((crnd_symbol_codec*)@this)->m_bit_count;
					}
					((crnd_symbol_codec*)@this)->m_bit_buf |= num6;
				}
			}
			int num7 = (((crnd_symbol_codec*)@this)->m_bit_buf >>> 16) + 1;
			int num9;
			int i;
			if ((uint)num7 <= (uint)((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_table_max_code)
			{
				int num8 = ((int*)((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_lookup)[(uint)(((crnd_symbol_codec*)@this)->m_bit_buf >>> 32 - ((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_table_bits)];
				if (num8 == -1)
				{
					crnd_assert.Invoke(String_hdsqwd.__pointer, String_vvx8bt.__pointer, 2691);
				}
				num9 = num8 & 0xFFFF;
				i = num8 >>> 16;
				if ((byte)(*(sbyte*)vector_unsigned_char_Operator_btiznu.Invoke(&((crnd_static_huffman_data_model*)model)->m_code_sizes, num9)) != i)
				{
					crnd_assert.Invoke(String_8pbqr2.__pointer, String_vvx8bt.__pointer, 2695);
				}
			}
			else
			{
				for (i = ((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_decode_start_code_size; (uint)num7 > (uint)((int*)(&((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_max_codes))[(uint)(i - 1)]; i++)
				{
				}
				int num10 = ((int*)(&((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_val_ptrs))[(uint)(i - 1)] + (((crnd_symbol_codec*)@this)->m_bit_buf >>> 32 - i);
				if ((uint)num10 >= (uint)((crnd_static_huffman_data_model*)model)->m_total_syms)
				{
					crnd_assert.Invoke(String_m5q5qr.__pointer, String_vvx8bt.__pointer, 2709);
					return 0;
				}
				num9 = (ushort)((short*)((crnd_prefix_coding_decoder_tables*)pDecode_tables)->m_sorted_symbol_order)[num10];
			}
			((crnd_symbol_codec*)@this)->m_bit_buf <<= i;
			((crnd_symbol_codec*)@this)->m_bit_count -= i;
			return num9;
		}
	}
}
