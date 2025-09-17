using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??B?$crn_packed_uint@$00@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::crn_packed_uint<1>::operator unsigned int(void) const")]
[CleanName("operator_unsigned_int")]
internal static partial class operator_unsigned_int_neugqod
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((byte)(*(sbyte*)(&((crnd_crn_packed_uint_1*)@this)->field_0)));
	}
}
