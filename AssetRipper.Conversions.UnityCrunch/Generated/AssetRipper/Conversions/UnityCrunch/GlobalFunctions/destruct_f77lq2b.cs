using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct@Vcrn_unpacker@crnd@@@helpers@crnd@@YAXPEAVcrn_unpacker@1@@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct<class crnd::crn_unpacker>(class crnd::crn_unpacker *)")]
[CleanName("destruct")]
internal static partial class destruct_f77lq2b
{
	private partial struct LocalVariables
	{
	}

	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class crnd::crn_unpacker *")] void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		crn_unpacker_Destructor.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
