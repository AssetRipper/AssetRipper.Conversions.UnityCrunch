using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?is_valid@crn_unpacker@crnd@@QEBA_NXZ")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::is_valid(void) const")]
internal static partial class is_valid
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((crnd_crn_unpacker*)@this)->field_0 == 519686845;
	}
}
