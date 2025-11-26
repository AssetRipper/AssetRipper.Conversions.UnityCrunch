using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BL@PODJHNGL@m_lookup?$FLt?$FN?5?$DN?$DN?5cUINT32_MAX?$AA@")]
[DemangledName("\"m_lookup[t] == cUINT32_MAX\"")]
[CleanName("String")]
internal static partial class String_5k7f4m
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

	unsafe static String_5k7f4m()
	{
		__pointer = unchecked((InlineArray27_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray27_SByte))));
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("m_lookup[t] == cUINT32_MAX\0"u8);
	}
}
