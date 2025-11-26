using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BL@IHIHLOKN@crnd_malloc?3?5out?5of?5memory?$AA@")]
[DemangledName("\"crnd_malloc: out of memory\"")]
[CleanName("String")]
internal static partial class String_eafej9
{
	public unsafe static InlineArray27_SByte* __pointer;

	public unsafe static InlineArray27_SByte Value
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

	unsafe static String_eafej9()
	{
		__pointer = unchecked((InlineArray27_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray27_SByte))));
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("crnd_malloc: out of memory\0"u8);
	}
}
