using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0FE@HNFCOJOA@?$CI?$CIuint32?$CJ?5reinterpret_cast?$DMuintp@")]
[DemangledName("\"((uint32) reinterpret_cast<uintp\"...")]
[CleanName("String")]
internal static partial class String_7eewk9
{
	public unsafe static InlineArray84_SByte* __pointer;

	public unsafe static InlineArray84_SByte Value
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

	unsafe static String_7eewk9()
	{
		__pointer = unchecked((InlineArray84_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray84_SByte))));
		Value = InlineArrayHelper.Create<InlineArray84_SByte, byte>("((uint32) reinterpret_cast<uintptr_t>(p_new) & (CRND_MIN_ALLOC_ALIGNMENT - 1)) == 0\0"u8);
	}
}
