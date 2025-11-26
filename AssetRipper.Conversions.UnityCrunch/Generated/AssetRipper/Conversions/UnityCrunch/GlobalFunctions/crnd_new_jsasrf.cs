using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vcrn_unpacker@crnd@@@crnd@@YAPEAVcrn_unpacker@0@XZ")]
[DemangledName("class crnd::crn_unpacker * __cdecl crnd::crnd_new<class crnd::crn_unpacker>(void)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_jsasrf
{
	[return: NativeType("class crnd::crn_unpacker *")]
	public unsafe static void* Invoke()
	{
		void* ptr = crnd_malloc.Invoke(392L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		void* result = construct_fgrjha.Invoke(ptr2);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
