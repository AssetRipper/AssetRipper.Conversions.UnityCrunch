using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0EG@EDDPBAMB@?$CItotal_syms?5?$DO?$DN?51?$CJ?5?$CG?$CG?5?$CItotal_syms@")]
[DemangledName("\"(total_syms >= 1) && (total_syms\"...")]
[CleanName("String")]
internal static partial class String_katrg3
{
	public unsafe static InlineArray70_SByte* __pointer;

	public unsafe static InlineArray70_SByte Value
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

	unsafe static String_katrg3()
	{
		__pointer = unchecked((InlineArray70_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray70_SByte))));
		Value = InlineArrayHelper.Create<InlineArray70_SByte, byte>("(total_syms >= 1) && (total_syms <= prefix_coding::cMaxSupportedSyms)\0"u8);
	}
}
