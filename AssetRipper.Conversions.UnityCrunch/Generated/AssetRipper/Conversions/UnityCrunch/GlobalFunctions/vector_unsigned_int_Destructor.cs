using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1?$vector@I@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned int>::~vector<unsigned int>(void)")]
internal static partial class vector_unsigned_int_Destructor
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		clear_utei2oa.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			StackFrameList.Current.Clear(startFrame);
			return;
		}
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
