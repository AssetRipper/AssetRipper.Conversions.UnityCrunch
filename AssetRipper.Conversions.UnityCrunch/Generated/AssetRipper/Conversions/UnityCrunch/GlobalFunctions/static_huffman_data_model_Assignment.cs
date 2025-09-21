using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4static_huffman_data_model@crnd@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class crnd::static_huffman_data_model & __cdecl crnd::static_huffman_data_model::operator=(class crnd::static_huffman_data_model const &)")]
internal static partial class static_huffman_data_model_Assignment
{
	[return: NativeType("class crnd::static_huffman_data_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class crnd::static_huffman_data_model const &")] void* rhs)
	{
		if (@this == rhs)
		{
			return @this;
		}
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->field_0 = ((crnd_static_huffman_data_model*)rhs)->field_0;
			vector_unsigned_char_Assignment.Invoke(other: &((crnd_static_huffman_data_model*)rhs)->field_1, @this: &((crnd_static_huffman_data_model*)@this)->field_1);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			if (Get_alloc_failed.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1))
			{
				clear_egw7ktb.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				return @this;
			}
			if (((crnd_static_huffman_data_model*)rhs)->field_2 != null)
			{
				if (((crnd_static_huffman_data_model*)@this)->field_2 != null)
				{
					decoder_tables_Assignment.Invoke(other: ((crnd_static_huffman_data_model*)rhs)->field_2, @this: ((crnd_static_huffman_data_model*)@this)->field_2);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
				}
				else
				{
					void* field_ = crnd_new_vzd3zqa.Invoke(((crnd_static_huffman_data_model*)rhs)->field_2);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					((crnd_static_huffman_data_model*)@this)->field_2 = field_;
				}
			}
			else
			{
				crnd_delete_rldcmnc.Invoke(((crnd_static_huffman_data_model*)@this)->field_2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((crnd_static_huffman_data_model*)@this)->field_2 = null;
			}
			return @this;
		}
	}
}
