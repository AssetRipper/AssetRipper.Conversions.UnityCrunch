using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0GA@BGEENDKK@?$CItotal_syms?5?$DO?$DN?51?$CJ?5?$CG?$CG?5?$CItotal_syms@")]
[DemangledName("\"(total_syms >= 1) && (total_syms\"...")]
[CleanName("String")]
internal static partial class String_ejppfib
{
	public unsafe static InlineArray_96_w3otm9c* __pointer;

	public unsafe static InlineArray_96_w3otm9c Value
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
		__pointer = unchecked((InlineArray_96_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_96_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_96_w3otm9c, byte>("(total_syms >= 1) && (total_syms <= prefix_coding::cMaxSupportedSyms) && (code_size_limit >= 1)\0"u8);
	}
}
