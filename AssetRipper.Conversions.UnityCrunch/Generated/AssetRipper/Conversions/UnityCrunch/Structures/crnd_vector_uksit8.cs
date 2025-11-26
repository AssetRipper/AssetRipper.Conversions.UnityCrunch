using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.crnd::vector")]
[DemangledName("crnd::vector")]
[CleanName("crnd_vector")]
public partial struct crnd_vector_uksit8
{
	[FieldOffset(0)]
	public unsafe void* m_p;

	[FieldOffset(8)]
	public int m_size;

	[FieldOffset(12)]
	public int m_capacity;

	[FieldOffset(16)]
	public sbyte m_alloc_failed;
}
