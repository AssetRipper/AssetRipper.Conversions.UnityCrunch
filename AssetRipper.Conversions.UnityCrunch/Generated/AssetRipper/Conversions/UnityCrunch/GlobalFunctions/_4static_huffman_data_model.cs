using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4static_huffman_data_model@crnd@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class crnd::static_huffman_data_model & __cdecl crnd::static_huffman_data_model::operator=(class crnd::static_huffman_data_model const &)")]
internal static partial class _4static_huffman_data_model
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public unsafe void* field_1;
	}

	public unsafe static void* Invoke(void* @this, void* rhs)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = rhs;
		unchecked
		{
			if (@this == startFrame.GetLocalsPointer<LocalVariables>()->field_1)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = @this;
			}
			else
			{
				((crnd_static_huffman_data_model*)@this)->field_0 = ((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_0;
				_4_vector.Invoke(other: &((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_1, @this: &((crnd_static_huffman_data_model*)@this)->field_1);
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
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = @this;
				}
				else
				{
					if (((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_2 != null)
					{
						if (((crnd_static_huffman_data_model*)@this)->field_2 != null)
						{
							_4decoder_tables.Invoke(other: ((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_2, @this: ((crnd_static_huffman_data_model*)@this)->field_2);
							if (ExceptionInfo.Current != null)
							{
								return null;
							}
						}
						else
						{
							void* field_ = crnd_new_vzd3zqa.Invoke(((crnd_static_huffman_data_model*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_2);
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
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = @this;
				}
			}
			void* field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_2;
		}
	}
}
