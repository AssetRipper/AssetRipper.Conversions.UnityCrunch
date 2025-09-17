using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("class.crnd::static_huffman_data_model")]
public partial struct crnd_static_huffman_data_model
{
	[FieldOffset(0)]
	public int field_0;

	[FieldOffset(8)]
	public crnd_vector field_1;

	[FieldOffset(32)]
	public unsafe void* field_2;
}
