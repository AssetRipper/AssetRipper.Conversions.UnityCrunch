using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??B?$crn_packed_uint@$03@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::crn_packed_uint<4>::operator unsigned int(void) const")]
internal static partial class crn_packed_uint_4_ToUInt32
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked(((byte)(*(sbyte*)(&((crnd_crn_packed_uint_jymcebc*)@this)->field_0)) << 24) | ((byte)((sbyte*)(&((crnd_crn_packed_uint_jymcebc*)@this)->field_0))[1] << 16) | ((byte)((sbyte*)(&((crnd_crn_packed_uint_jymcebc*)@this)->field_0))[2] << 8) | (byte)((sbyte*)(&((crnd_crn_packed_uint_jymcebc*)@this)->field_0))[3]);
	}
}
