using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BP@PAJOIOJH@model?4m_code_sizes?$FLsym?$FN?5?$DN?$DN?5len?$AA@")]
[DemangledName("\"model.m_code_sizes[sym] == len\"")]
[CleanName("String")]
internal static partial class String_e4i4x9a
{
	public unsafe static InlineArray_31_w3otm9c* __pointer;

	public unsafe static InlineArray_31_w3otm9c Value
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

	unsafe static String_e4i4x9a()
	{
		__pointer = unchecked((InlineArray_31_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_31_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_31_w3otm9c, byte>("model.m_code_sizes[sym] == len\0"u8);
	}
}
