using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_dxt5_from_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt5_from_linear")]
internal static partial class g_dxt5_from_linear
{
	public unsafe static InlineArray_8_w3otm9c* __pointer;

	public unsafe static InlineArray_8_w3otm9c Value
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

	unsafe static g_dxt5_from_linear()
	{
		__pointer = unchecked((InlineArray_8_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_8_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_8_w3otm9c, byte>(new byte[8] { 0, 2, 3, 4, 5, 6, 7, 1 });
	}
}
