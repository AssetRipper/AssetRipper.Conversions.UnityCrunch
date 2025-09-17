using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?compute_decoder_table_bits@static_huffman_data_model@crnd@@AEBAIXZ")]
[DemangledName("private: unsigned int __cdecl crnd::static_huffman_data_model::compute_decoder_table_bits(void) const")]
internal static partial class compute_decoder_table_bits
{
	public unsafe static int Invoke(void* @this)
	{
		int num = 0;
		num = 0;
		unchecked
		{
			if ((uint)((crnd_static_huffman_data_model*)@this)->field_0 > 16u)
			{
				num = (byte)(sbyte)minimum.Invoke(1 + ceil_log2i.Invoke(((crnd_static_huffman_data_model*)@this)->field_0), 11);
			}
			return num;
		}
	}
}
