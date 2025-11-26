using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1static_huffman_data_model@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::static_huffman_data_model::~static_huffman_data_model(void)")]
internal static partial class static_huffman_data_model_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_static_huffman_data_model*)@this)->m_pDecode_tables != null)
			{
				crnd_delete_bvucig.Invoke(((crnd_static_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current != null)
				{
					ExceptionInfo.Current = null;
					std_terminate.Invoke();
					throw null;
				}
			}
			vector_unsigned_char_Destructor.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes);
		}
	}
}
