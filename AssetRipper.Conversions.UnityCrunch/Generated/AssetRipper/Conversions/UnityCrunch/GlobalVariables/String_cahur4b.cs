using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CL@INIAFNGL@?$CIx?5?$DM?5cDXTBlockSize?$CJ?5?$CG?$CG?5?$CIy?5?$DM?5cDXT@")]
[DemangledName("\"(x < cDXTBlockSize) && (y < cDXT\"...")]
[CleanName("String")]
internal static partial class String_cahur4b
{
	public unsafe static InlineArray_43_w3otm9c* __pointer;

	public unsafe static InlineArray_43_w3otm9c Value
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

	unsafe static String_cahur4b()
	{
		__pointer = unchecked((InlineArray_43_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_43_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_43_w3otm9c, byte>("(x < cDXTBlockSize) && (y < cDXTBlockSize)\0"u8);
	}
}
