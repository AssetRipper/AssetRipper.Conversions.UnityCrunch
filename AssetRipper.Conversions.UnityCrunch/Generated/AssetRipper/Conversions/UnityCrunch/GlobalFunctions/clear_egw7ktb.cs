using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@static_huffman_data_model@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::static_huffman_data_model::clear(void)")]
[CleanName("clear")]
internal static partial class clear_egw7ktb
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->field_0 = 0;
			clear_q4odfmb.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			if (((crnd_static_huffman_data_model*)@this)->field_2 != null)
			{
				crnd_delete_rldcmnc.Invoke(((crnd_static_huffman_data_model*)@this)->field_2);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_static_huffman_data_model*)@this)->field_2 = null;
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
