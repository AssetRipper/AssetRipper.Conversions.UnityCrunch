using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BL@ILGLACHG@m_bit_count?5?$DM?$DN?5cBitBufSize?$AA@")]
[DemangledName("\"m_bit_count <= cBitBufSize\"")]
[CleanName("String")]
internal static partial class String_kf9n5db
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

	unsafe static String_kf9n5db()
	{
		__pointer = unchecked((InlineArray27_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray27_SByte))));
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("m_bit_count <= cBitBufSize\0"u8);
	}
}
