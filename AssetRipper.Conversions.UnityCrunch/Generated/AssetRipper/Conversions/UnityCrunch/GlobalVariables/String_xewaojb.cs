using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BL@IHIHLOKN@crnd_malloc?3?5out?5of?5memory?$AA@")]
[DemangledName("\"crnd_malloc: out of memory\"")]
[CleanName("String")]
internal static partial class String_xewaojb
{
	public unsafe static InlineArray_27_w3otm9c* __pointer;

	public unsafe static InlineArray_27_w3otm9c Value
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

	unsafe static String_xewaojb()
	{
		__pointer = unchecked((InlineArray_27_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_27_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_27_w3otm9c, byte>("crnd_malloc: out of memory\0"u8);
	}
}
