using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAXPEAVdecoder_tables@prefix_coding@0@@Z")]
[DemangledName("void __cdecl crnd::crnd_delete<class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables *)")]
[CleanName("crnd_delete")]
internal static partial class crnd_delete_bvucig
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class crnd::prefix_coding::decoder_tables *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		destruct_kgci2b.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			crnd_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
