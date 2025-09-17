using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct@Vdecoder_tables@prefix_coding@crnd@@V123@@helpers@crnd@@YAPEAVdecoder_tables@prefix_coding@1@PEAV231@AEBV231@@Z")]
[DemangledName("class crnd::prefix_coding::decoder_tables * __cdecl crnd::helpers::construct<class crnd::prefix_coding::decoder_tables, class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables *, class crnd::prefix_coding::decoder_tables const &)")]
[CleanName("construct")]
internal static partial class construct_zybj4yc
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void* Invoke(void* p, void* init)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		decoder_tables_Constructor_3v4xfjd.Invoke(p, init);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return p;
	}
}
