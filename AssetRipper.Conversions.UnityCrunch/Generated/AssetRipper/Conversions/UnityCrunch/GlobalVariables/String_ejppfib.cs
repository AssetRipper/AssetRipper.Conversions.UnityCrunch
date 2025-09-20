using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0GA@BGEENDKK@?$CItotal_syms?5?$DO?$DN?51?$CJ?5?$CG?$CG?5?$CItotal_syms@")]
[DemangledName("\"(total_syms >= 1) && (total_syms\"...")]
[CleanName("String")]
internal static partial class String_ejppfib
{
	public unsafe static InlineArray96_SByte* __pointer;

	public unsafe static InlineArray96_SByte Value
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

	unsafe static String_ejppfib()
	{
		__pointer = unchecked((InlineArray96_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray96_SByte))));
		Value = InlineArrayHelper.Create<InlineArray96_SByte, byte>("(total_syms >= 1) && (total_syms <= prefix_coding::cMaxSupportedSyms) && (code_size_limit >= 1)\0"u8);
	}
}
