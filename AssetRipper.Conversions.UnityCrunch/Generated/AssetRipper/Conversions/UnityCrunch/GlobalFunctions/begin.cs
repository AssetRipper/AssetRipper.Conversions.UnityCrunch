using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?begin@?$vector@G@crnd@@QEAAPEAGXZ")]
[DemangledName("public: unsigned short * __cdecl crnd::vector<unsigned short>::begin(void)")]
internal static partial class begin
{
	[return: NativeType("unsigned short *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((crnd_vector_rf9iywd*)@this)->field_0;
	}
}
