using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?size@?$vector@G@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::vector<unsigned short>::size(void) const")]
[CleanName("size")]
internal static partial class size_lxodu4b
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_vector_rf9iywd*)@this)->field_1;
	}
}
