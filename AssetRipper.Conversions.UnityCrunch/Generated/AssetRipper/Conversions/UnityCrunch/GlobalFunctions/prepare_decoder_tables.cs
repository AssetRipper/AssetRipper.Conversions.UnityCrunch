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
			int num = size_23co4id.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1);
			int num2;
			if ((uint)num >= 1u && (uint)num <= 8192u)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_3h2uiyd.__pointer, String_yguirrd.__pointer, 2468);
				num2 = 0;
			}
			((crnd_static_huffman_data_model*)@this)->field_0 = num;
			if (((crnd_static_huffman_data_model*)@this)->field_2 == null)
			{
				void* field_ = crnd_new_9bg4xgd.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((crnd_static_huffman_data_model*)@this)->field_2 = field_;
			}
			bool result = init_igqra9d.Invoke(((crnd_static_huffman_data_model*)@this)->field_2, table_bits: compute_decoder_table_bits.Invoke(@this), pCodesizes: vector_unsigned_char_Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, 0), num_syms: ((crnd_static_huffman_data_model*)@this)->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			return result;
		}
	}
}
