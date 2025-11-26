using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?prepare_decoder_tables@static_huffman_data_model@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::static_huffman_data_model::prepare_decoder_tables(void)")]
internal static partial class prepare_decoder_tables
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			int num = size_e35phn.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes);
			if ((uint)num < 1u || (uint)num > 8192u)
			{
				crnd_assert.Invoke(String_katrg3.__pointer, String_vvx8bt.__pointer, 2468);
			}
			((crnd_static_huffman_data_model*)@this)->m_total_syms = num;
			if (((crnd_static_huffman_data_model*)@this)->m_pDecode_tables == null)
			{
				void* pDecode_tables = crnd_new_nwmzm6.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = pDecode_tables;
			}
			bool result = init_kvw3hm.Invoke(((crnd_static_huffman_data_model*)@this)->m_pDecode_tables, table_bits: compute_decoder_table_bits.Invoke(@this), pCodesizes: vector_unsigned_char_Operator_ggxbum.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes, 0), num_syms: ((crnd_static_huffman_data_model*)@this)->m_total_syms);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
