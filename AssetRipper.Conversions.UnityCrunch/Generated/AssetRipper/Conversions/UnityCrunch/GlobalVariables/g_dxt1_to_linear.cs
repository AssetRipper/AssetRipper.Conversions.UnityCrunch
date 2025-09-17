using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_dxt1_to_linear@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_dxt1_to_linear")]
internal static partial class g_dxt1_to_linear
{
	private static InlineArray_4_w3otm9c __value;

	public static InlineArray_4_w3otm9c Value
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

	static g_dxt1_to_linear()
	{
		Value = InlineArrayHelper.Create<InlineArray_4_w3otm9c, byte>(new byte[4] { 0, 3, 1, 2 });
	}
}
