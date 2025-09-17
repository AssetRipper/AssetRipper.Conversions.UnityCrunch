using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_unshifted_max_code@decoder_tables@prefix_coding@crnd@@QEBAII@Z")]
[DemangledName("public: unsigned int __cdecl crnd::prefix_coding::decoder_tables::get_unshifted_max_code(unsigned int) const")]
internal static partial class Get_unshifted_max_code
{
	public unsafe static int Invoke(void* @this, int len)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		num2 = len;
		unchecked
		{
			int num4;
			if ((uint)num2 >= 1u && (uint)num2 <= 16u)
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ajzw4md.__pointer, String_yguirrd.__pointer, 1514);
				num4 = 0;
			}
			num3 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num2 - 1)];
			if (num3 == 0)
			{
				return -1;
			}
			return num3 - 1 >>> 16 - num2;
		}
	}
}
