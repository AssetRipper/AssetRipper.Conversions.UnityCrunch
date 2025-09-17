using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@?$vector@E@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<unsigned char>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_q4odfmb
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		unchecked
		{
			if (((crnd_vector*)@this)->field_0 != null)
			{
				destruct_array_dhbxund.Invoke(parameter_1: ((crnd_vector*)@this)->field_1, parameter_0: ((crnd_vector*)@this)->field_0);
				crnd_free.Invoke(((crnd_vector*)@this)->field_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector*)@this)->field_0 = null;
				((crnd_vector*)@this)->field_1 = 0;
				((crnd_vector*)@this)->field_2 = 0;
			}
			((crnd_vector*)@this)->field_3 = 0;
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
