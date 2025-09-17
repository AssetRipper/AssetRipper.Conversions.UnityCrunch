using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0N@OGENALEG@value?5?$DM?$DN?50xF?$AA@")]
[DemangledName("\"value <= 0xF\"")]
[CleanName("String")]
internal static partial class String_azii4xc
{
	public unsafe static InlineArray_13_w3otm9c* __pointer;

	public unsafe static InlineArray_13_w3otm9c Value
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

	unsafe static String_azii4xc()
	{
		__pointer = unchecked((InlineArray_13_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_13_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_13_w3otm9c, byte>("value <= 0xF\0"u8);
	}
}
