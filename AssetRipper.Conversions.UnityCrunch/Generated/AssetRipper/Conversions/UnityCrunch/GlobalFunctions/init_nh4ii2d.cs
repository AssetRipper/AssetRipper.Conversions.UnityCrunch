using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init@static_huffman_data_model@crnd@@QEAA_NIPEBEI@Z")]
[DemangledName("public: bool __cdecl crnd::static_huffman_data_model::init(unsigned int, unsigned char const *, unsigned int)")]
[CleanName("init")]
internal static partial class init_nh4ii2d
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int total_syms, [NativeType("unsigned char const *")] void* pCode_sizes, [NativeType("unsigned int")] int code_size_limit)
	{
		int num = code_size_limit;
		unchecked
		{
			if ((uint)total_syms < 1u || (uint)total_syms > 8192u || (uint)num < 1u)
			{
				crnd_assert.Invoke(String_ejppfib.__pointer, String_yguirrd.__pointer, 2433);
			}
			num = minimum.Invoke(num, 16);
			bool flag = resize_rzzl5xd.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes, total_syms);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			int num2 = -1;
			int num3 = 0;
			for (int i = 0; (uint)i < (uint)total_syms; i++)
			{
				int num4 = (byte)((sbyte*)pCode_sizes)[(uint)i];
				*(sbyte*)vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes, i) = (sbyte)num4;
				num2 = minimum.Invoke(num2, num4);
				num3 = maximum.Invoke(num3, num4);
			}
			if ((uint)num3 < 1u || (uint)num3 > 32u || (uint)num2 > (uint)num)
			{
				return false;
			}
			if ((uint)num3 > (uint)num)
			{
				return false;
			}
			if (((crnd_static_huffman_data_model*)@this)->m_pDecode_tables == null)
			{
				void* pDecode_tables = crnd_new_9bg4xgd.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = pDecode_tables;
			}
			bool flag2 = init_igqra9d.Invoke(((crnd_static_huffman_data_model*)@this)->m_pDecode_tables, table_bits: compute_decoder_table_bits.Invoke(@this), pCodesizes: vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes, 0), num_syms: ((crnd_static_huffman_data_model*)@this)->m_total_syms);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			return true;
		}
	}
}
