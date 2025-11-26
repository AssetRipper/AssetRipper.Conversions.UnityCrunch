using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_05LAPONLG@false?$AA@")]
[DemangledName("\"false\"")]
[CleanName("String")]
internal static partial class String_ak4am9
{
	public unsafe static InlineArray6_SByte* __pointer;

	public unsafe static InlineArray6_SByte Value
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

	unsafe static String_ak4am9()
	{
		__pointer = unchecked((InlineArray6_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray6_SByte))));
		Value = InlineArrayHelper.Create<InlineArray6_SByte, byte>("false\0"u8);
	}
}
