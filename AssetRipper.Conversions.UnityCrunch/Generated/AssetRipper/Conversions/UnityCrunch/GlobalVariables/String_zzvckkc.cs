using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0DC@IPOLIHPJ@num?5?$CG?$CG?5?$CInum?5?$DN?$DN?5?$HOreinterpret_cast@")]
[DemangledName("\"num && (num == ~reinterpret_cast\"...")]
[CleanName("String")]
internal static partial class String_zzvckkc
{
	public unsafe static InlineArray_50_w3otm9c* __pointer;

	public unsafe static InlineArray_50_w3otm9c Value
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

	unsafe static String_zzvckkc()
	{
		__pointer = unchecked((InlineArray_50_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_50_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_50_w3otm9c, byte>("num && (num == ~reinterpret_cast<uint32*>(p)[-2])\0"u8);
	}
}
