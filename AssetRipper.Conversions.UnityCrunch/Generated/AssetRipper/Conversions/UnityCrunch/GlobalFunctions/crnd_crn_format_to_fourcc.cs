using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_crn_format_to_fourcc@crnd@@YAIW4crn_format@@@Z")]
[DemangledName("unsigned int __cdecl crnd::crnd_crn_format_to_fourcc(enum crn_format)")]
internal static partial class crnd_crn_format_to_fourcc
{
	public unsafe static int Invoke(int fmt)
	{
		int num = 0;
		switch (fmt)
		{
		case 0:
			return 827611204;
		case 1:
			return 861165636;
		case 2:
			return 894720068;
		case 7:
			return 1498952257;
		case 8:
			return 843666497;
		case 9:
			return 826889281;
		case 3:
			return 1501053763;
		case 4:
			return 1383614328;
		case 5:
			return 1380075384;
		case 6:
			return 1380075329;
		case 10:
			return 826496069;
		case 11:
			return 843273285;
		case 12:
			return 1093817413;
		case 13:
			return 1395741765;
		case 14:
			return 1396781637;
		default:
			crnd_assert.Invoke(String_xxn2wad.__pointer, String_yguirrd.__pointer, 2126);
			return 0;
		}
	}
}
