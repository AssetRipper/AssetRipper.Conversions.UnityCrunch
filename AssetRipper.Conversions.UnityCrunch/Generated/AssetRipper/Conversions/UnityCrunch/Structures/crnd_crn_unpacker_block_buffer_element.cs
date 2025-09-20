using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.crnd::crn_unpacker::block_buffer_element")]
[DemangledName("crnd::crn_unpacker::block_buffer_element")]
public partial struct crnd_crn_unpacker_block_buffer_element
{
	[FieldOffset(0)]
	public short field_0;

	[FieldOffset(2)]
	public short field_1;

	[FieldOffset(4)]
	public short field_2;

	[FieldOffset(6)]
	public short field_3;
}
