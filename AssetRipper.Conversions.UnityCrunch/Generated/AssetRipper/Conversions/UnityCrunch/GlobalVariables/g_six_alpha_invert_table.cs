using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_six_alpha_invert_table@crnd@@3QBEB")]
[DemangledName("unsigned char const *const crnd::g_six_alpha_invert_table")]
internal static partial class g_six_alpha_invert_table
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

	static g_six_alpha_invert_table()
	{
		Value = InlineArrayHelper.Create<InlineArray_8_w3otm9c, byte>(new byte[8] { 1, 0, 5, 4, 3, 2, 6, 7 });
	}
}
