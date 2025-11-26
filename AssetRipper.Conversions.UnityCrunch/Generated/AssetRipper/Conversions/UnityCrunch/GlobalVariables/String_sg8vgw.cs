using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0N@OGENALEG@value?5?$DM?$DN?50xF?$AA@")]
[DemangledName("\"value <= 0xF\"")]
[CleanName("String")]
internal static partial class String_sg8vgw
{
	public unsafe static InlineArray13_SByte* __pointer;

	public unsafe static InlineArray13_SByte Value
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

	unsafe static String_sg8vgw()
	{
		__pointer = unchecked((InlineArray13_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray13_SByte))));
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("value <= 0xF\0"u8);
	}
}
