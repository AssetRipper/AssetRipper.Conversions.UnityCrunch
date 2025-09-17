using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1crn_unpacker@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::crn_unpacker::~crn_unpacker(void)")]
internal static partial class crn_unpacker_Destructor
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		unchecked
		{
			((crnd_crn_unpacker*)@this)->field_0 = 0;
			vector_struct_crnd_crn_unpacker_block_buffer_element_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->field_12);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_short_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->field_11);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_short_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_int_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->field_9);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			vector_unsigned_int_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			crnd_static_huffman_data_model* field_ = (crnd_static_huffman_data_model*)(&((crnd_crn_unpacker*)@this)->field_7);
			nint num = (nint)(field_ + 2L);
			while (true)
			{
				crnd_static_huffman_data_model* ptr = (crnd_static_huffman_data_model*)(num + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
				static_huffman_data_model_Destructor.Invoke(ptr);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr == field_)
				{
					break;
				}
				num = (nint)ptr;
			}
			crnd_static_huffman_data_model* field_2 = (crnd_static_huffman_data_model*)(&((crnd_crn_unpacker*)@this)->field_6);
			nint num2 = (nint)(field_2 + 2L);
			while (true)
			{
				crnd_static_huffman_data_model* ptr2 = (crnd_static_huffman_data_model*)(num2 + (nint)(-1) * sizeof(crnd_static_huffman_data_model));
				static_huffman_data_model_Destructor.Invoke(ptr2);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				if (ptr2 == field_2)
				{
					break;
				}
				num2 = (nint)ptr2;
			}
			static_huffman_data_model_Destructor.Invoke(&((crnd_crn_unpacker*)@this)->field_5);
			if (ExceptionInfo.Current == null)
			{
				StackFrameList.Current.Clear(startFrame);
			}
		}
	}
}
