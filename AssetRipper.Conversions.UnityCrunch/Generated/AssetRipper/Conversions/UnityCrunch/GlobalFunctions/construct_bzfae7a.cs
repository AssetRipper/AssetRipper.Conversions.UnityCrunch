using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct@Vcrn_unpacker@crnd@@@helpers@crnd@@YAPEAVcrn_unpacker@1@PEAV21@@Z")]
[DemangledName("class crnd::crn_unpacker * __cdecl crnd::helpers::construct<class crnd::crn_unpacker>(class crnd::crn_unpacker *)")]
[CleanName("construct")]
internal static partial class construct_bzfae7a
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void* Invoke(void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		crn_unpacker_Constructor.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return p;
	}
}
