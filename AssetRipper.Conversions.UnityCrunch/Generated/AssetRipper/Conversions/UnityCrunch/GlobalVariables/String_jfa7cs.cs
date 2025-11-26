using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0DA@IKAFKHEK@min_new_capacity?5?$DM?5?$CI0x7FFF0000U?5@")]
[DemangledName("\"min_new_capacity < (0x7FFF0000U \"...")]
[CleanName("String")]
internal static partial class String_jfa7cs
{
	public unsafe static InlineArray48_SByte* __pointer;

	public unsafe static InlineArray48_SByte Value
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

	unsafe static String_jfa7cs()
	{
		__pointer = unchecked((InlineArray48_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray48_SByte))));
		Value = InlineArrayHelper.Create<InlineArray48_SByte, byte>("min_new_capacity < (0x7FFF0000U / element_size)\0"u8);
	}
}
