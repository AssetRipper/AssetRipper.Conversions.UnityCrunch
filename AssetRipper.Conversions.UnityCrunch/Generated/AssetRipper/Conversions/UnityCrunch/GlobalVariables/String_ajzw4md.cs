using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CM@KDBBDIAC@?$CIlen?5?$DO?$DN?51?$CJ?5?$CG?$CG?5?$CIlen?5?$DM?$DN?5cMaxExpect@")]
[DemangledName("\"(len >= 1) && (len <= cMaxExpect\"...")]
[CleanName("String")]
internal static partial class String_ajzw4md
{
	public unsafe static InlineArray_44_w3otm9c* __pointer;

	public unsafe static InlineArray_44_w3otm9c Value
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

	unsafe static String_ajzw4md()
	{
		__pointer = unchecked((InlineArray_44_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_44_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_44_w3otm9c, byte>("(len >= 1) && (len <= cMaxExpectedCodeSize)\0"u8);
	}
}
