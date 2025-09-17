using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_alpha@dxt3_block@crnd@@QEBAIII_N@Z")]
[DemangledName("public: unsigned int __cdecl crnd::dxt3_block::get_alpha(unsigned int, unsigned int, bool) const")]
internal static partial class Get_alpha
{
	public unsafe static int Invoke(void* @this, int x, int y, bool scaled)
	{
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		b = (scaled ? ((sbyte)1) : ((sbyte)0));
		num = y;
		num2 = x;
		unchecked
		{
			int num4;
			if ((uint)num2 < 4u && (uint)num < 4u)
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_cahur4b.__pointer, String_yguirrd.__pointer, 2850);
				num4 = 0;
			}
			num3 = (byte)((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)((num << 1) + (num2 >>> 1))];
			if ((num2 & 1) != 0)
			{
				num3 >>>= 4;
			}
			num3 &= 0xF;
			if ((b & 1) == 1)
			{
				num3 = (num3 << 4) | num3;
			}
			return num3;
		}
	}
}
