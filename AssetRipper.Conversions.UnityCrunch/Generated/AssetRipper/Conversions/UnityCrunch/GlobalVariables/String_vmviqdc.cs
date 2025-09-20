using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BF@OMHJAMGG@m_size?5?$DM?$DN?5m_capacity?$AA@")]
[DemangledName("\"m_size <= m_capacity\"")]
[CleanName("String")]
internal static partial class String_vmviqdc
{
	public unsafe static InlineArray21_SByte* __pointer;

	public unsafe static InlineArray21_SByte Value
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

	unsafe static String_vmviqdc()
	{
		__pointer = unchecked((InlineArray21_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray21_SByte))));
		Value = InlineArrayHelper.Create<InlineArray21_SByte, byte>("m_size <= m_capacity\0"u8);
	}
}
