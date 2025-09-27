using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_data@crn_unpacker@crnd@@QEBAPEBXXZ")]
[DemangledName("public: void const * __cdecl crnd::crn_unpacker::get_data(void) const")]
internal static partial class Get_data
{
	[return: NativeType("void const *")]
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((crnd_crn_unpacker*)@this)->m_pData;
	}
}
