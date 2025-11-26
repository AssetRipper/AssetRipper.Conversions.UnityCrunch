using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1?$vector@I@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned int>::~vector<unsigned int>(void)")]
internal static partial class vector_unsigned_int_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		clear_2hj7fd.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			return;
		}
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
