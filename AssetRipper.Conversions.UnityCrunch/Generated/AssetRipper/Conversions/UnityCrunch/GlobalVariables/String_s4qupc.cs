using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CM@KDBBDIAC@?$CIlen?5?$DO?$DN?51?$CJ?5?$CG?$CG?5?$CIlen?5?$DM?$DN?5cMaxExpect@")]
[DemangledName("\"(len >= 1) && (len <= cMaxExpect\"...")]
[CleanName("String")]
internal static partial class String_s4qupc
{
	public unsafe static InlineArray44_SByte* __pointer;

	public unsafe static InlineArray44_SByte Value
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

	unsafe static String_s4qupc()
	{
		__pointer = unchecked((InlineArray44_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray44_SByte))));
		Value = InlineArrayHelper.Create<InlineArray44_SByte, byte>("(len >= 1) && (len <= cMaxExpectedCodeSize)\0"u8);
	}
}
