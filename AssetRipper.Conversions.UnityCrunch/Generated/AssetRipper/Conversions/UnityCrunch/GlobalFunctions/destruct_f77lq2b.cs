using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct@Vcrn_unpacker@crnd@@@helpers@crnd@@YAXPEAVcrn_unpacker@1@@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct<class crnd::crn_unpacker>(class crnd::crn_unpacker *)")]
[CleanName("destruct")]
internal static partial class destruct_f77lq2b
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("class crnd::crn_unpacker *")] void* p)
	{
		crn_unpacker_Destructor.Invoke(p);
	}
}
