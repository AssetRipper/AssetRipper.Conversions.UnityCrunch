using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0static_huffman_data_model@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::static_huffman_data_model::static_huffman_data_model(void)")]
[CleanName("static_huffman_data_model_Constructor")]
internal static partial class static_huffman_data_model_Constructor_c98ih8
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->m_total_syms = 0;
			vector_unsigned_char_Constructor.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes);
			((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = null;
			return @this;
		}
	}
}
