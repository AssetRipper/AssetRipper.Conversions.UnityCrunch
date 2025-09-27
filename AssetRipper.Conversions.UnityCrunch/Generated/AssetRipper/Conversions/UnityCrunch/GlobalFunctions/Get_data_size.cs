using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_data_size@crn_unpacker@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::crn_unpacker::get_data_size(void) const")]
internal static partial class Get_data_size
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_crn_unpacker*)@this)->m_data_size;
	}
}
