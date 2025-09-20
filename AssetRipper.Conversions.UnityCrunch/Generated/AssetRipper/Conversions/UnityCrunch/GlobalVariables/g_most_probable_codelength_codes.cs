using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_most_probable_codelength_codes@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_most_probable_codelength_codes")]
internal static partial class g_most_probable_codelength_codes
{
	public unsafe static InlineArray21_SByte* __pointer;

	public unsafe static InlineArray21_SByte Value
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

	unsafe static g_most_probable_codelength_codes()
	{
		__pointer = unchecked((InlineArray21_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray21_SByte))));
		Value = InlineArrayHelper.Create<InlineArray21_SByte, byte>(new byte[21]
		{
			17, 18, 19, 20, 0, 8, 7, 9, 6, 10,
			5, 11, 4, 12, 3, 13, 2, 14, 1, 15,
			16
		});
	}
}
