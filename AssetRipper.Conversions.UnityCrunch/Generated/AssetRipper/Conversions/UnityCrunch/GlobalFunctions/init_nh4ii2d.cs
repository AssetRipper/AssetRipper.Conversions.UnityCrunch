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
		bool flag = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = code_size_limit;
		unchecked
		{
			int num6;
			if ((uint)total_syms >= 1u && (uint)total_syms <= 8192u && (uint)num5 >= 1u)
			{
				num6 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ejppfib.__pointer, String_yguirrd.__pointer, 2433);
				num6 = 0;
			}
			num5 = minimum.Invoke(num5, 16);
			bool flag2 = resize_rzzl5xd.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, total_syms);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			num = -1;
			num2 = 0;
			for (num3 = 0; (uint)num3 < (uint)total_syms; num3++)
			{
				num4 = (byte)((sbyte*)pCode_sizes)[(uint)num3];
				*(sbyte*)vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, num3) = (sbyte)num4;
				num = minimum.Invoke(num, num4);
				num2 = maximum.Invoke(num2, num4);
			}
			if ((uint)num2 < 1u || (uint)num2 > 32u || (uint)num > (uint)num5)
			{
				return false;
			}
			if ((uint)num2 > (uint)num5)
			{
				return false;
			}
			if (((crnd_static_huffman_data_model*)@this)->field_2 == null)
			{
				void* field_ = crnd_new_9bg4xgd.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((crnd_static_huffman_data_model*)@this)->field_2 = field_;
			}
			bool flag3 = init_igqra9d.Invoke(((crnd_static_huffman_data_model*)@this)->field_2, table_bits: compute_decoder_table_bits.Invoke(@this), pCodesizes: vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, 0), num_syms: ((crnd_static_huffman_data_model*)@this)->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			return true;
		}
	}
}
