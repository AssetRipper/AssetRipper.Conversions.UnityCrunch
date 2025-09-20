using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAPEAVdecoder_tables@prefix_coding@0@XZ")]
[DemangledName("class crnd::prefix_coding::decoder_tables * __cdecl crnd::crnd_new<class crnd::prefix_coding::decoder_tables>(void)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_9bg4xgd
{
	[return: NativeType("class crnd::prefix_coding::decoder_tables *")]
	public unsafe static void* Invoke()
	{
		void* ptr = null;
		void* ptr2 = crnd_malloc.Invoke(192L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr3 = ptr2;
		if (ptr3 == null)
		{
			return null;
		}
		return construct_e5fhx3a.Invoke(ptr3);
	}
}
