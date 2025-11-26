using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0N@MHDHCCDI@num_codes?$FLc?$FN?$AA@")]
[DemangledName("\"num_codes[c]\"")]
[CleanName("String")]
internal static partial class String_ez6imn
{
	public unsafe static InlineArray13_SByte* __pointer;

	public unsafe static InlineArray13_SByte Value
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

	unsafe static String_ez6imn()
	{
		__pointer = unchecked((InlineArray13_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray13_SByte))));
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("num_codes[c]\0"u8);
	}
}
