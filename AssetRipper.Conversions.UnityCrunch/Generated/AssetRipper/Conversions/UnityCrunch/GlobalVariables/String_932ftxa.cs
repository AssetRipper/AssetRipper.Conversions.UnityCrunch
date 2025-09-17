using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0O@DJHKEBCN@value?5?$DM?$DN?50xFF?$AA@")]
[DemangledName("\"value <= 0xFF\"")]
[CleanName("String")]
internal static partial class String_932ftxa
{
	public unsafe static InlineArray_14_w3otm9c* __pointer;

	public unsafe static InlineArray_14_w3otm9c Value
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

	unsafe static String_932ftxa()
	{
		__pointer = unchecked((InlineArray_14_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_14_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_14_w3otm9c, byte>("value <= 0xFF\0"u8);
	}
}
