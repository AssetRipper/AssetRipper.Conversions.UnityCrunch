using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CM@KMJOAIO@new_capacity?5?$CG?$CG?5?$CInew_capacity?5?$DO?5@")]
[DemangledName("\"new_capacity && (new_capacity > \"...")]
[CleanName("String")]
internal static partial class String_rugjm7a
{
	public unsafe static InlineArray44_SByte* __pointer;

	public unsafe static InlineArray44_SByte Value
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

	unsafe static String_rugjm7a()
	{
		__pointer = unchecked((InlineArray44_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray44_SByte))));
		Value = InlineArrayHelper.Create<InlineArray44_SByte, byte>("new_capacity && (new_capacity > m_capacity)\0"u8);
	}
}
