using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BB@FLHHDBIK@t?5?$CB?$DN?5cUINT32_MAX?$AA@")]
[DemangledName("\"t != cUINT32_MAX\"")]
[CleanName("String")]
internal static partial class String_fwybtzb
{
	public unsafe static InlineArray_17_w3otm9c* __pointer;

	public unsafe static InlineArray_17_w3otm9c Value
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

	unsafe static String_fwybtzb()
	{
		__pointer = unchecked((InlineArray_17_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_17_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_17_w3otm9c, byte>("t != cUINT32_MAX\0"u8);
	}
}
