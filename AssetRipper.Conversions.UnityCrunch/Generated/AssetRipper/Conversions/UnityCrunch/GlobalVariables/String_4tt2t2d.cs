using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_09GBHJNKCG@index?5?$DM?52?$AA@")]
[DemangledName("\"index < 2\"")]
[CleanName("String")]
internal static partial class String_4tt2t2d
{
	public unsafe static InlineArray10_SByte* __pointer;

	public unsafe static InlineArray10_SByte Value
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

	unsafe static String_4tt2t2d()
	{
		__pointer = unchecked((InlineArray10_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray10_SByte))));
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("index < 2\0"u8);
	}
}
