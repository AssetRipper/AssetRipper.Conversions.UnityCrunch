using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BN@MHDEPPEE@?$CIlo?5?$DM?$DN?50xFF?$CJ?5?$CG?$CG?5?$CIhi?5?$DM?$DN?50xFF?$CJ?$AA@")]
[DemangledName("\"(lo <= 0xFF) && (hi <= 0xFF)\"")]
[CleanName("String")]
internal static partial class String_7bcfjea
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

	unsafe static String_7bcfjea()
	{
		__pointer = unchecked((InlineArray_29_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_29_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_29_w3otm9c, byte>("(lo <= 0xFF) && (hi <= 0xFF)\0"u8);
	}
}
