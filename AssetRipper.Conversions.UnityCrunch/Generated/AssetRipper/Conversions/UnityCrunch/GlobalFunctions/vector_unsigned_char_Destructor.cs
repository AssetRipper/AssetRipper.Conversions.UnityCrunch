using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1?$vector@E@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned char>::~vector<unsigned char>(void)")]
internal static partial class vector_unsigned_char_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		clear_q4odfmb.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			return;
		}
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
