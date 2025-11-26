using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BD@COLBNJCC@crnd_free?3?5bad?5ptr?$AA@")]
[DemangledName("\"crnd_free: bad ptr\"")]
[CleanName("String")]
internal static partial class String_6fnra8
{
	public unsafe static InlineArray19_SByte* __pointer;

	public unsafe static InlineArray19_SByte Value
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

	unsafe static String_6fnra8()
	{
		__pointer = unchecked((InlineArray19_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray19_SByte))));
		Value = InlineArrayHelper.Create<InlineArray19_SByte, byte>("crnd_free: bad ptr\0"u8);
	}
}
