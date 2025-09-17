using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?set_alpha@dxt3_block@crnd@@QEAAXIII_N@Z")]
[DemangledName("public: void __cdecl crnd::dxt3_block::set_alpha(unsigned int, unsigned int, unsigned int, bool)")]
internal static partial class Set_alpha
{
	public unsafe static void Invoke(void* @this, int x, int y, int value, bool scaled)
	{
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		b = (scaled ? ((sbyte)1) : ((sbyte)0));
		num = value;
		num2 = y;
		num3 = x;
		unchecked
		{
			int num6;
			if ((uint)num3 < 4u && (uint)num2 < 4u)
			{
				num6 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_cahur4b.__pointer, String_yguirrd.__pointer, 2831);
				num6 = 0;
			}
			int num8;
			if ((b & 1) == 1)
			{
				int num7;
				if ((uint)num <= 255u)
				{
					num7 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_932ftxa.__pointer, String_yguirrd.__pointer, 2834);
					num7 = 0;
				}
				num = (int)((uint)(num * 15 + 128) / 255u);
			}
			else if ((uint)num <= 15u)
			{
				num8 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_azii4xc.__pointer, String_yguirrd.__pointer, 2837);
				num8 = 0;
			}
			num4 = (num2 << 1) + (num3 >>> 1);
			num5 = (byte)((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)num4];
			((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)num4] = (sbyte)((num5 & ((15 << ((num3 & 1) << 2)) ^ -1)) | (num << ((num3 & 1) << 2)));
		}
	}
}
