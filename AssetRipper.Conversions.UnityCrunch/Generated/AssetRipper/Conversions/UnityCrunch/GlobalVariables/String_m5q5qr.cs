using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_01GBGANLPD@0?$AA@")]
[DemangledName("\"0\"")]
[CleanName("String")]
internal static partial class String_m5q5qr
{
	public unsafe static InlineArray2_SByte* __pointer;

	public unsafe static InlineArray2_SByte Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static String_m5q5qr()
	{
		__pointer = unchecked((InlineArray2_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray2_SByte))));
		Value = InlineArrayHelper.Create<InlineArray2_SByte, byte>("0\0"u8);
	}
}
