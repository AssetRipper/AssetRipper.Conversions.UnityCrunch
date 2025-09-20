using System.Runtime.InteropServices;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("class.crnd::symbol_codec")]
[DemangledName("crnd::symbol_codec")]
public partial struct crnd_symbol_codec
{
	[FieldOffset(0)]
	public unsafe void* field_0;

	[FieldOffset(8)]
	public unsafe void* field_1;

	[FieldOffset(16)]
	public unsafe void* field_2;

	[FieldOffset(24)]
	public int field_3;

	[FieldOffset(28)]
	public int field_4;

	[FieldOffset(32)]
	public int field_5;
}
