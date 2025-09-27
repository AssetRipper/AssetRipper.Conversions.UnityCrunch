using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2)]
[MangledName("struct.crnd::crn_packed_uint")]
[DemangledName("crnd::crn_packed_uint")]
[CleanName("crnd_crn_packed_uint")]
public partial struct crnd_crn_packed_uint_hnsywfd
{
	[FieldOffset(0)]
	public InlineArray2_SByte m_buf;
}
