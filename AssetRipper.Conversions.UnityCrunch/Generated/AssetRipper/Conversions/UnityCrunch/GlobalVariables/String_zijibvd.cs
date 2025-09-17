using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BE@LPKGDAOF@crnd_msize?3?5bad?5ptr?$AA@")]
[DemangledName("\"crnd_msize: bad ptr\"")]
[CleanName("String")]
internal static partial class String_zijibvd
{
	public unsafe static InlineArray_20_w3otm9c* __pointer;

	public unsafe static InlineArray_20_w3otm9c Value
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

	unsafe static String_zijibvd()
	{
		__pointer = unchecked((InlineArray_20_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_20_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_20_w3otm9c, byte>("crnd_msize: bad ptr\0"u8);
	}
}
