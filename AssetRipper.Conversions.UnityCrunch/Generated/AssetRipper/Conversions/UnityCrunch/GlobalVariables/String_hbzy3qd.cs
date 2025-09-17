using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0DA@IKAFKHEK@min_new_capacity?5?$DM?5?$CI0x7FFF0000U?5@")]
[DemangledName("\"min_new_capacity < (0x7FFF0000U \"...")]
[CleanName("String")]
internal static partial class String_hbzy3qd
{
	public unsafe static InlineArray_48_w3otm9c* __pointer;

	public unsafe static InlineArray_48_w3otm9c Value
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

	unsafe static String_hbzy3qd()
	{
		__pointer = unchecked((InlineArray_48_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_48_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_48_w3otm9c, byte>("min_new_capacity < (0x7FFF0000U / element_size)\0"u8);
	}
}
