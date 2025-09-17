using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BG@KKLOAKHB@crnd_realloc?3?5bad?5ptr?$AA@")]
[DemangledName("\"crnd_realloc: bad ptr\"")]
[CleanName("String")]
internal static partial class String_ifury7b
{
	public unsafe static InlineArray_22_w3otm9c* __pointer;

	public unsafe static InlineArray_22_w3otm9c Value
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

	unsafe static String_ifury7b()
	{
		__pointer = unchecked((InlineArray_22_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_22_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_22_w3otm9c, byte>("crnd_realloc: bad ptr\0"u8);
	}
}
