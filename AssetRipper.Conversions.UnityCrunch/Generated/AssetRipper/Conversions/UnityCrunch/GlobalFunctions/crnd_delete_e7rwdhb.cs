using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete@Vcrn_unpacker@crnd@@@crnd@@YAXPEAVcrn_unpacker@0@@Z")]
[DemangledName("void __cdecl crnd::crnd_delete<class crnd::crn_unpacker>(class crnd::crn_unpacker *)")]
[CleanName("crnd_delete")]
internal static partial class crnd_delete_e7rwdhb
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;
	}

	public unsafe static void Invoke(void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = p;
		if (startFrame.GetLocalsPointer<LocalVariables>()->field_0 != null)
		{
			destruct_f77lq2b.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
			crnd_free.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_0);
			if (ExceptionInfo.Current != null)
			{
				return;
			}
		}
		StackFrameList.Current.Clear(startFrame);
	}
}
