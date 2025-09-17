using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?g_pUser_data@crnd@@3PEAXEA")]
[DemangledName("void *crnd::g_pUser_data")]
internal static partial class g_pUser_data
{
	private unsafe static void* __value;

	public unsafe static void* Value
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

	unsafe static g_pUser_data()
	{
		Value = null;
	}
}
