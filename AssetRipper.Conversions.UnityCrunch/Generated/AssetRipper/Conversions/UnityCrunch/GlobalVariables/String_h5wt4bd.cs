using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BL@PODJHNGL@m_lookup?$FLt?$FN?5?$DN?$DN?5cUINT32_MAX?$AA@")]
[DemangledName("\"m_lookup[t] == cUINT32_MAX\"")]
[CleanName("String")]
internal static partial class String_h5wt4bd
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

	unsafe static String_h5wt4bd()
	{
		__pointer = unchecked((InlineArray_27_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_27_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_27_w3otm9c, byte>("m_lookup[t] == cUINT32_MAX\0"u8);
	}
}
