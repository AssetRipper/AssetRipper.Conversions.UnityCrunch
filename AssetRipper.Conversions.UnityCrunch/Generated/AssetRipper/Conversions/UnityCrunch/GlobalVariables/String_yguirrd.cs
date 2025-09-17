using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BM@OFEGABIL@?4?2Original?1inc?1crn_decomp?4h?$AA@")]
[DemangledName("\".\\\\Original/inc/crn_decomp.h\"")]
[CleanName("String")]
internal static partial class String_yguirrd
{
	public unsafe static InlineArray_28_w3otm9c* __pointer;

	public unsafe static InlineArray_28_w3otm9c Value
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
		__pointer = unchecked((InlineArray_28_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_28_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_28_w3otm9c, byte>(".\\Original/inc/crn_decomp.h\0"u8);
	}
}
