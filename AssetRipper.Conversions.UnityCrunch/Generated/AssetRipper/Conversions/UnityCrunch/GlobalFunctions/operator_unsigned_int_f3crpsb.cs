using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??B?$crn_packed_uint@$01@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::crn_packed_uint<2>::operator unsigned int(void) const")]
[CleanName("operator_unsigned_int")]
internal static partial class operator_unsigned_int_f3crpsb
{
	public unsafe static int Invoke(void* @this)
	{
		return unchecked(((byte)(*(sbyte*)(&((crnd_crn_packed_uint*)@this)->field_0)) << 8) | (byte)((sbyte*)(&((crnd_crn_packed_uint*)@this)->field_0))[1]);
	}
}
