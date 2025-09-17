using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CD@GFDHKLGC@?$CIlo?5?$DM?$DN?50xFFFFU?$CJ?5?$CG?$CG?5?$CIhi?5?$DM?$DN?50xFFFF@")]
[DemangledName("\"(lo <= 0xFFFFU) && (hi <= 0xFFFF\"...")]
[CleanName("String")]
internal static partial class String_myspu3d
{
	public unsafe static InlineArray_35_w3otm9c* __pointer;

	public unsafe static InlineArray_35_w3otm9c Value
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

	unsafe static String_myspu3d()
	{
		__pointer = unchecked((InlineArray_35_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_35_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_35_w3otm9c, byte>("(lo <= 0xFFFFU) && (hi <= 0xFFFFU)\0"u8);
	}
}
