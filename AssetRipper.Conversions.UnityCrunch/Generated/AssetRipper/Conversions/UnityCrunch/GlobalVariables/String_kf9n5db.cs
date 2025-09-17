using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BL@ILGLACHG@m_bit_count?5?$DM?$DN?5cBitBufSize?$AA@")]
[DemangledName("\"m_bit_count <= cBitBufSize\"")]
[CleanName("String")]
internal static partial class String_kf9n5db
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

	unsafe static String_kf9n5db()
	{
		__pointer = unchecked((InlineArray_27_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_27_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_27_w3otm9c, byte>("m_bit_count <= cBitBufSize\0"u8);
	}
}
