using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BH@OAHGHCMP@t?5?$DM?5?$CI1U?5?$DM?$DM?5table_bits?$CJ?$AA@")]
[DemangledName("\"t < (1U << table_bits)\"")]
[CleanName("String")]
internal static partial class String_g3mv3q
{
	public unsafe static InlineArray23_SByte* __pointer;

	public unsafe static InlineArray23_SByte Value
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

	unsafe static String_g3mv3q()
	{
		__pointer = unchecked((InlineArray23_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray23_SByte))));
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("t < (1U << table_bits)\0"u8);
	}
}
