using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct@Vdecoder_tables@prefix_coding@crnd@@@helpers@crnd@@YAXPEAVdecoder_tables@prefix_coding@1@@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct<class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables *)")]
[CleanName("destruct")]
internal static partial class destruct_py7r2pc
{
	private partial struct LocalVariables
	{
	}

	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class crnd::prefix_coding::decoder_tables *")] void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>();
		decoder_tables_Destructor.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
