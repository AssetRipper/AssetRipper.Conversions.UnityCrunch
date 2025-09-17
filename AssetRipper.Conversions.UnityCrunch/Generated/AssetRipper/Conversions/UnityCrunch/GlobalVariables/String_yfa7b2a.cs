using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BH@OAHGHCMP@t?5?$DM?5?$CI1U?5?$DM?$DM?5table_bits?$CJ?$AA@")]
[DemangledName("\"t < (1U << table_bits)\"")]
[CleanName("String")]
internal static partial class String_yfa7b2a
{
	public unsafe static InlineArray_23_w3otm9c* __pointer;

	public unsafe static InlineArray_23_w3otm9c Value
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

	unsafe static String_yfa7b2a()
	{
		__pointer = unchecked((InlineArray_23_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_23_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_23_w3otm9c, byte>("t < (1U << table_bits)\0"u8);
	}
}
