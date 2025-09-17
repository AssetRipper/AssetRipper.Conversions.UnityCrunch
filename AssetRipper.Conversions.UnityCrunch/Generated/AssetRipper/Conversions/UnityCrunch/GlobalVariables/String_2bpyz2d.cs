using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0DN@BKINGKOB@crnd_validate_file?$CI?$CGnew_header?0?5@")]
[DemangledName("\"crnd_validate_file(&new_header, \"...")]
[CleanName("String")]
internal static partial class String_2bpyz2d
{
	public unsafe static InlineArray_61_w3otm9c* __pointer;

	public unsafe static InlineArray_61_w3otm9c Value
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

	unsafe static String_2bpyz2d()
	{
		__pointer = unchecked((InlineArray_61_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_61_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_61_w3otm9c, byte>("crnd_validate_file(&new_header, actual_base_data_size, NULL)\0"u8);
	}
}
