using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_alloc_failed@?$vector@E@crnd@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned char>::get_alloc_failed(void) const")]
internal static partial class Get_alloc_failed
{
	public unsafe static bool Invoke(void* @this)
	{
		return (unchecked((crnd_vector*)@this)->field_3 & 1) == 1;
	}
}
