using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 36)]
[MangledName("struct.crnd::crn_texture_info")]
[DemangledName("crnd::crn_texture_info")]
public partial struct crnd_crn_texture_info
{
	[FieldOffset(0)]
	public int m_struct_size;

	[FieldOffset(4)]
	public int m_width;

	[FieldOffset(8)]
	public int m_height;

	[FieldOffset(12)]
	public int m_levels;

	[FieldOffset(16)]
	public int m_faces;

	[FieldOffset(20)]
	public int m_bytes_per_block;

	[FieldOffset(24)]
	public int m_userdata0;

	[FieldOffset(28)]
	public int m_userdata1;

	[FieldOffset(32)]
	public int m_format;
}
