using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAPEAVdecoder_tables@prefix_coding@0@AEBV120@@Z")]
[DemangledName("class crnd::prefix_coding::decoder_tables * __cdecl crnd::crnd_new<class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables const &)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_485jak
{
	[return: NativeType("class crnd::prefix_coding::decoder_tables *")]
	public unsafe static void* Invoke([NativeType("class crnd::prefix_coding::decoder_tables const &")] void* init)
	{
		void* ptr = crnd_malloc.Invoke(192L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		void* ptr2 = ptr;
		if (ptr2 == null)
		{
			return null;
		}
		void* result = construct_va3fwv.Invoke(ptr2, init);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return result;
	}
}
