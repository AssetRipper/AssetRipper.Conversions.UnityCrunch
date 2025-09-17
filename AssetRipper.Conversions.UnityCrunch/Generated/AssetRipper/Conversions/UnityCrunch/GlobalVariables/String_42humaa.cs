using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0FE@HNFCOJOA@?$CI?$CIuint32?$CJ?5reinterpret_cast?$DMuintp@")]
[DemangledName("\"((uint32) reinterpret_cast<uintp\"...")]
[CleanName("String")]
internal static partial class String_42humaa
{
	public unsafe static InlineArray_84_w3otm9c* __pointer;

	public unsafe static InlineArray_84_w3otm9c Value
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

	unsafe static String_42humaa()
	{
		__pointer = unchecked((InlineArray_84_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_84_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_84_w3otm9c, byte>("((uint32) reinterpret_cast<uintptr_t>(p_new) & (CRND_MIN_ALLOC_ALIGNMENT - 1)) == 0\0"u8);
	}
}
