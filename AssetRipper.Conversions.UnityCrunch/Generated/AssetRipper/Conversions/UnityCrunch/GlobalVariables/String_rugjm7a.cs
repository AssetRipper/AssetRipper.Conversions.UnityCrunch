using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0CM@KMJOAIO@new_capacity?5?$CG?$CG?5?$CInew_capacity?5?$DO?5@")]
[DemangledName("\"new_capacity && (new_capacity > \"...")]
[CleanName("String")]
internal static partial class String_rugjm7a
{
	public unsafe static InlineArray_44_w3otm9c* __pointer;

	public unsafe static InlineArray_44_w3otm9c Value
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
		__pointer = unchecked((InlineArray_44_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_44_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_44_w3otm9c, byte>("new_capacity && (new_capacity > m_capacity)\0"u8);
	}
}
