using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct@Vcrn_unpacker@crnd@@@helpers@crnd@@YAPEAVcrn_unpacker@1@PEAV21@@Z")]
[DemangledName("class crnd::crn_unpacker * __cdecl crnd::helpers::construct<class crnd::crn_unpacker>(class crnd::crn_unpacker *)")]
[CleanName("construct")]
internal static partial class construct_fgrjha
{
	[return: NativeType("class crnd::crn_unpacker *")]
	public unsafe static void* Invoke([NativeType("class crnd::crn_unpacker *")] void* p)
	{
		crn_unpacker_Constructor.Invoke(p);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		return p;
	}
}
