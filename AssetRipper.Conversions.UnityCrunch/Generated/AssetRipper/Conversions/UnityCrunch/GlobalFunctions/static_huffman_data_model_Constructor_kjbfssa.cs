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
			((crnd_static_huffman_data_model*)@this)->field_0 = 0;
			crnd_vector_f3cmzmc* field_ = &((crnd_static_huffman_data_model*)@this)->field_1;
			vector_unsigned_char_Constructor.Invoke(field_);
			((crnd_static_huffman_data_model*)@this)->field_2 = null;
			static_huffman_data_model_Assignment.Invoke(@this, other);
			if (ExceptionInfo.Current == null)
			{
				return @this;
			}
			ExceptionInfo current = ExceptionInfo.Current;
			ExceptionInfo.Current = null;
			vector_unsigned_char_Destructor.Invoke(field_);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			ExceptionInfo.Current = current;
			return null;
		}
	}
}
