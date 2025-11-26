using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete@Vcrn_unpacker@crnd@@@crnd@@YAXPEAVcrn_unpacker@0@@Z")]
[DemangledName("void __cdecl crnd::crnd_delete<class crnd::crn_unpacker>(class crnd::crn_unpacker *)")]
[CleanName("crnd_delete")]
internal static partial class crnd_delete_ps427s
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class crnd::crn_unpacker *")] void* p)
	{
		if (p == null)
		{
			return;
		}
		destruct_msam3p.Invoke(p);
		if (ExceptionInfo.Current == null)
		{
			crnd_free.Invoke(p);
			if (ExceptionInfo.Current == null)
			{
			}
		}
	}
}
