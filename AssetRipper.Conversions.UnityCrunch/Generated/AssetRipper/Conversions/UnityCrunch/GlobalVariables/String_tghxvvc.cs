using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CB@FHBEHCLP@?$CFs?$CI?$CFu?$CJ?3?5Assertion?5failure?3?5?$CC?$CFs?$CC?6@")]
[DemangledName("\"%s(%u): Assertion failure: \\\"%s\\\"\\n\"...")]
[CleanName("String")]
internal static partial class String_tghxvvc
{
	public unsafe static InlineArray_33_w3otm9c* __pointer;

	public unsafe static InlineArray_33_w3otm9c Value
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

	unsafe static String_tghxvvc()
	{
		__pointer = unchecked((InlineArray_33_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_33_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_33_w3otm9c, byte>("%s(%u): Assertion failure: \"%s\"\n\0"u8);
	}
}
