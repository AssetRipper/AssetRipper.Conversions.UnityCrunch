using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BN@MHDEPPEE@?$CIlo?5?$DM?$DN?50xFF?$CJ?5?$CG?$CG?5?$CIhi?5?$DM?$DN?50xFF?$CJ?$AA@")]
[DemangledName("\"(lo <= 0xFF) && (hi <= 0xFF)\"")]
[CleanName("String")]
internal static partial class String_57w95k
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

	unsafe static String_57w95k()
	{
		__pointer = unchecked((InlineArray29_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray29_SByte))));
		Value = InlineArrayHelper.Create<InlineArray29_SByte, byte>("(lo <= 0xFF) && (hi <= 0xFF)\0"u8);
	}
}
