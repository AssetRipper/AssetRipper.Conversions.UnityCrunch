using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BP@PAJOIOJH@model?4m_code_sizes?$FLsym?$FN?5?$DN?$DN?5len?$AA@")]
[DemangledName("\"model.m_code_sizes[sym] == len\"")]
[CleanName("String")]
internal static partial class String_8pbqr2
{
	public unsafe static InlineArray31_SByte* __pointer;

	public unsafe static InlineArray31_SByte Value
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

	unsafe static String_8pbqr2()
	{
		__pointer = unchecked((InlineArray31_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray31_SByte))));
		Value = InlineArrayHelper.Create<InlineArray31_SByte, byte>("model.m_code_sizes[sym] == len\0"u8);
	}
}
