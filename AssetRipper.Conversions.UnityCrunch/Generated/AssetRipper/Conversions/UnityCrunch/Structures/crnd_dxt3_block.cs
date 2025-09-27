using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.crnd::dxt3_block")]
[DemangledName("crnd::dxt3_block")]
public partial struct crnd_dxt3_block
{
	[FieldOffset(0)]
	public InlineArray8_SByte m_alpha;
}
