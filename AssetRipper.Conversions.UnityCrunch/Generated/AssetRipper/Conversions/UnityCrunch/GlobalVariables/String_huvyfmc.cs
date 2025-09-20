using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BP@GCONNLPO@next_level_ofs?5?$DO?5cur_level_ofs?$AA@")]
[DemangledName("\"next_level_ofs > cur_level_ofs\"")]
[CleanName("String")]
internal static partial class String_huvyfmc
{
	public unsafe static InlineArray31_SByte* __pointer;

	public unsafe static InlineArray31_SByte Value
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

	unsafe static String_huvyfmc()
	{
		__pointer = unchecked((InlineArray31_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray31_SByte))));
		Value = InlineArrayHelper.Create<InlineArray31_SByte, byte>("next_level_ofs > cur_level_ofs\0"u8);
	}
}
