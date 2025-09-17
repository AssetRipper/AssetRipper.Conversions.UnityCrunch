using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BN@PCBNPNGF@sorted_pos?5?$DM?5total_used_syms?$AA@")]
[DemangledName("\"sorted_pos < total_used_syms\"")]
[CleanName("String")]
internal static partial class String_ws3o7xb
{
	public unsafe static InlineArray_29_w3otm9c* __pointer;

	public unsafe static InlineArray_29_w3otm9c Value
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

	unsafe static String_ws3o7xb()
	{
		__pointer = unchecked((InlineArray_29_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_29_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_29_w3otm9c, byte>("sorted_pos < total_used_syms\0"u8);
	}
}
