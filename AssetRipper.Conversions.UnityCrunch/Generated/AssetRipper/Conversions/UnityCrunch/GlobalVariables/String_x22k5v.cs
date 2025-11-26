using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BE@LPKGDAOF@crnd_msize?3?5bad?5ptr?$AA@")]
[DemangledName("\"crnd_msize: bad ptr\"")]
[CleanName("String")]
internal static partial class String_x22k5v
{
	public unsafe static InlineArray20_SByte* __pointer;

	public unsafe static InlineArray20_SByte Value
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

	unsafe static String_x22k5v()
	{
		__pointer = unchecked((InlineArray20_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray20_SByte))));
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("crnd_msize: bad ptr\0"u8);
	}
}
