using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_05LAPONLG@false?$AA@")]
[DemangledName("\"false\"")]
[CleanName("String")]
internal static partial class String_xxn2wad
{
	public unsafe static InlineArray_6_w3otm9c* __pointer;

	public unsafe static InlineArray_6_w3otm9c Value
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

	unsafe static String_xxn2wad()
	{
		__pointer = unchecked((InlineArray_6_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_6_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_6_w3otm9c, byte>("false\0"u8);
	}
}
