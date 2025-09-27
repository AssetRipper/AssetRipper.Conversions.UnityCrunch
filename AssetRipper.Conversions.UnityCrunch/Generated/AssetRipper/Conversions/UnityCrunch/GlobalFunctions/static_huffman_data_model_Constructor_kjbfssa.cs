using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0static_huffman_data_model@crnd@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl crnd::static_huffman_data_model::static_huffman_data_model(class crnd::static_huffman_data_model const &)")]
[CleanName("static_huffman_data_model_Constructor")]
internal static partial class static_huffman_data_model_Constructor_kjbfssa
{
	public unsafe static void* Invoke(void* @this, [NativeType("class crnd::static_huffman_data_model const &")] void* other)
	{
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->m_total_syms = 0;
			crnd_vector_f3cmzmc* code_sizes = &((crnd_static_huffman_data_model*)@this)->m_code_sizes;
			vector_unsigned_char_Constructor.Invoke(code_sizes);
			((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = null;
			static_huffman_data_model_Assignment.Invoke(@this, other);
			if (ExceptionInfo.Current == null)
			{
				return @this;
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_char_Destructor.Invoke(code_sizes);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current;
			return null;
		}
	}
}
