using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BM@OFEGABIL@?4?2Original?1inc?1crn_decomp?4h?$AA@")]
[DemangledName("\".\\\\Original/inc/crn_decomp.h\"")]
[CleanName("String")]
internal static partial class String_yguirrd
{
	public unsafe static InlineArray28_SByte* __pointer;

	public unsafe static InlineArray28_SByte Value
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

	unsafe static String_yguirrd()
	{
		__pointer = unchecked((InlineArray28_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray28_SByte))));
		Value = InlineArrayHelper.Create<InlineArray28_SByte, byte>(".\\Original/inc/crn_decomp.h\0"u8);
	}
}
