using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0static_huffman_data_model@crnd@@QEAA@AEBV01@@Z")]
[DemangledName("public: __cdecl crnd::static_huffman_data_model::static_huffman_data_model(class crnd::static_huffman_data_model const &)")]
[CleanName("static_huffman_data_model_Constructor")]
internal static partial class static_huffman_data_model_Constructor_kjbfssa
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void* Invoke(void* @this, void* other)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->field_0 = 0;
			crnd_vector* field_ = &((crnd_static_huffman_data_model*)@this)->field_1;
			vector_unsigned_char_Constructor.Invoke(field_);
			((crnd_static_huffman_data_model*)@this)->field_2 = null;
			_4static_huffman_data_model.Invoke(@this, other);
			if (ExceptionInfo.Current == null)
			{
				StackFrameList.Current.Clear(startFrame);
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
