using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAXPEAVdecoder_tables@prefix_coding@0@@Z")]
[DemangledName("void __cdecl crnd::crnd_delete<class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables *)")]
[CleanName("crnd_delete")]
internal static partial class crnd_delete_rldcmnc
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
			destruct_py7r2pc.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_0);
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
