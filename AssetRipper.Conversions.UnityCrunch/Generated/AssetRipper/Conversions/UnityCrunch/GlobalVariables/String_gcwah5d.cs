using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BD@COLBNJCC@crnd_free?3?5bad?5ptr?$AA@")]
[DemangledName("\"crnd_free: bad ptr\"")]
[CleanName("String")]
internal static partial class String_gcwah5d
{
	public unsafe static InlineArray_19_w3otm9c* __pointer;

	public unsafe static InlineArray_19_w3otm9c Value
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

	unsafe static String_gcwah5d()
	{
		__pointer = unchecked((InlineArray_19_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_19_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_19_w3otm9c, byte>("crnd_free: bad ptr\0"u8);
	}
}
