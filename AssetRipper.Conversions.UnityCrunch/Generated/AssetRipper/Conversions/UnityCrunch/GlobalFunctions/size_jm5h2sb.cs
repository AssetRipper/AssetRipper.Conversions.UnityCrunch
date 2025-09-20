using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?size@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::size(void) const")]
[CleanName("size")]
internal static partial class size_jm5h2sb
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_vector_y4ukjxd*)@this)->field_1;
	}
}
