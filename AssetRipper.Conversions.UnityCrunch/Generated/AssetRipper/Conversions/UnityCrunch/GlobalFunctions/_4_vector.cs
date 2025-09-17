using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4?$vector@E@crnd@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class crnd::vector<unsigned char> & __cdecl crnd::vector<unsigned char>::operator=(class crnd::vector<unsigned char> const &)")]
internal static partial class _4_vector
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void* Invoke(void* @this, void* other)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		assign.Invoke(@this, other);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		StackFrameList.Current.Clear(startFrame);
		return @this;
	}
}
