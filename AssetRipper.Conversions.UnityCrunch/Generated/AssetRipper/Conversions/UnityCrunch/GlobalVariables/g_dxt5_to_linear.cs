using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_dxt5_to_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt5_to_linear")]
internal static partial class g_dxt5_to_linear
{
	private static InlineArray_8_w3otm9c __value;

	public static InlineArray_8_w3otm9c Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	static g_dxt5_to_linear()
	{
		Value = InlineArrayHelper.Create<InlineArray_8_w3otm9c, byte>(new byte[8] { 0, 7, 1, 2, 3, 4, 5, 6 });
	}
}
