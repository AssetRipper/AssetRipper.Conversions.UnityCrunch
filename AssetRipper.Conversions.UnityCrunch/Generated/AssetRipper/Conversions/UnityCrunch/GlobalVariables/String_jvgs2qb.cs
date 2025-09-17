using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CC@GJMHEPH@pCodesizes?$FLsym_index?$FN?5?$DN?$DN?5codesiz@")]
[DemangledName("\"pCodesizes[sym_index] == codesiz\"...")]
[CleanName("String")]
internal static partial class String_jvgs2qb
{
	public unsafe static InlineArray_34_w3otm9c* __pointer;

	public unsafe static InlineArray_34_w3otm9c Value
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

	unsafe static String_jvgs2qb()
	{
		__pointer = unchecked((InlineArray_34_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_34_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_34_w3otm9c, byte>("pCodesizes[sym_index] == codesize\0"u8);
	}
}
