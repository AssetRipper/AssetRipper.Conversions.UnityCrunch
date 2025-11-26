using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BN@PCBNPNGF@sorted_pos?5?$DM?5total_used_syms?$AA@")]
[DemangledName("\"sorted_pos < total_used_syms\"")]
[CleanName("String")]
internal static partial class String_zzatd6
{
	public unsafe static InlineArray29_SByte* __pointer;

	public unsafe static InlineArray29_SByte Value
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

	unsafe static String_zzatd6()
	{
		__pointer = unchecked((InlineArray29_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray29_SByte))));
		Value = InlineArrayHelper.Create<InlineArray29_SByte, byte>("sorted_pos < total_used_syms\0"u8);
	}
}
