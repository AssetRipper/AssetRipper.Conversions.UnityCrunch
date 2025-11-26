using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.crnd::crn_palette")]
[DemangledName("crnd::crn_palette")]
public partial struct crnd_crn_palette
{
	[FieldOffset(0)]
	public crnd_crn_packed_uint_7g8wrq m_ofs;

	[FieldOffset(3)]
	public crnd_crn_packed_uint_7g8wrq m_size;

	[FieldOffset(6)]
	public crnd_crn_packed_uint_y3p293 m_num;
}
