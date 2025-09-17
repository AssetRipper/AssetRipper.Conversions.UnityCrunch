using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0L@GPMGHDBL@i?5?$DM?5m_size?$AA@")]
[DemangledName("\"i < m_size\"")]
[CleanName("String")]
internal static partial class String_ededlgd
{
	public unsafe static InlineArray_11_w3otm9c* __pointer;

	public unsafe static InlineArray_11_w3otm9c Value
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

	unsafe static String_ededlgd()
	{
		__pointer = unchecked((InlineArray_11_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_11_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_11_w3otm9c, byte>("i < m_size\0"u8);
	}
}
