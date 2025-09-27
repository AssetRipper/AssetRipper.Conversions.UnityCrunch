using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??B?$crn_packed_uint@$02@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::crn_packed_uint<3>::operator unsigned int(void) const")]
internal static partial class crn_packed_uint_3_ToUInt32
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked(((byte)(*(sbyte*)(&((crnd_crn_packed_uint_fru7ewb*)@this)->m_buf)) << 16) | ((byte)((sbyte*)(&((crnd_crn_packed_uint_fru7ewb*)@this)->m_buf))[1] << 8) | (byte)((sbyte*)(&((crnd_crn_packed_uint_fru7ewb*)@this)->m_buf))[2]);
	}
}
