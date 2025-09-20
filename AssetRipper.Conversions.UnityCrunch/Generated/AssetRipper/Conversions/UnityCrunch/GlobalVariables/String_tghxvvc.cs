using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CB@FHBEHCLP@?$CFs?$CI?$CFu?$CJ?3?5Assertion?5failure?3?5?$CC?$CFs?$CC?6@")]
[DemangledName("\"%s(%u): Assertion failure: \\\"%s\\\"\\n\"...")]
[CleanName("String")]
internal static partial class String_tghxvvc
{
	public unsafe static InlineArray33_SByte* __pointer;

	public unsafe static InlineArray33_SByte Value
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
		__pointer = unchecked((InlineArray33_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray33_SByte))));
		Value = InlineArrayHelper.Create<InlineArray33_SByte, byte>("%s(%u): Assertion failure: \"%s\"\n\0"u8);
	}
}
