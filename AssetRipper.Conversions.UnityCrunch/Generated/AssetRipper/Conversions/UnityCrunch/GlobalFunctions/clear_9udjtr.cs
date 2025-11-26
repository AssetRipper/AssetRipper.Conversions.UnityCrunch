using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@static_huffman_data_model@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::static_huffman_data_model::clear(void)")]
[CleanName("clear")]
internal static partial class clear_9udjtr
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->m_total_syms = 0;
			clear_mzsqxg.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes);
			if (ExceptionInfo.Current == null && ((crnd_static_huffman_data_model*)@this)->m_pDecode_tables != null)
			{
				crnd_delete_bvucig.Invoke(((crnd_static_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current == null)
				{
					((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = null;
				}
			}
		}
	}
}
