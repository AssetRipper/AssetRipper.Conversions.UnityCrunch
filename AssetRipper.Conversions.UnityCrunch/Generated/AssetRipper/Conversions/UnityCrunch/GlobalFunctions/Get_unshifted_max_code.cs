using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_unshifted_max_code@decoder_tables@prefix_coding@crnd@@QEBAII@Z")]
[DemangledName("public: unsigned int __cdecl crnd::prefix_coding::decoder_tables::get_unshifted_max_code(unsigned int) const")]
internal static partial class Get_unshifted_max_code
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int len)
	{
		int num = 0;
		int num2 = 0;
		unchecked
		{
			int num3;
			if ((uint)len >= 1u && (uint)len <= 16u)
			{
				num3 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ajzw4md.__pointer, String_yguirrd.__pointer, 1514);
				num3 = 0;
			}
			num2 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(len - 1)];
			if (num2 == 0)
			{
				return -1;
			}
			return num2 - 1 >>> 16 - len;
		}
	}
}
