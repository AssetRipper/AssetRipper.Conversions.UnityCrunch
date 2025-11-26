using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CD@GFDHKLGC@?$CIlo?5?$DM?$DN?50xFFFFU?$CJ?5?$CG?$CG?5?$CIhi?5?$DM?$DN?50xFFFF@")]
[DemangledName("\"(lo <= 0xFFFFU) && (hi <= 0xFFFF\"...")]
[CleanName("String")]
internal static partial class String_fp3rum
{
	public unsafe static InlineArray35_SByte* __pointer;

	public unsafe static InlineArray35_SByte Value
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

	unsafe static String_fp3rum()
	{
		__pointer = unchecked((InlineArray35_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray35_SByte))));
		Value = InlineArrayHelper.Create<InlineArray35_SByte, byte>("(lo <= 0xFFFFU) && (hi <= 0xFFFFU)\0"u8);
	}
}
