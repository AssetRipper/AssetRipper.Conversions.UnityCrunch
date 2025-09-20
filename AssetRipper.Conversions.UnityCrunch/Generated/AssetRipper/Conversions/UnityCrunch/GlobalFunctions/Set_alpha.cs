using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?set_alpha@dxt3_block@crnd@@QEAAXIII_N@Z")]
[DemangledName("public: void __cdecl crnd::dxt3_block::set_alpha(unsigned int, unsigned int, unsigned int, bool)")]
internal static partial class Set_alpha
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned int")] int x, [NativeType("unsigned int")] int y, [NativeType("unsigned int")] int value, [NativeType("bool")] bool scaled)
	{
		int num = 0;
		int num2 = 0;
		sbyte b = (scaled ? ((sbyte)1) : ((sbyte)0));
		int num3 = value;
		unchecked
		{
			int num4;
			if ((uint)x < 4u && (uint)y < 4u)
			{
				num4 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_cahur4b.__pointer, String_yguirrd.__pointer, 2831);
				num4 = 0;
			}
			int num6;
			if ((b & 1) == 1)
			{
				int num5;
				if ((uint)num3 <= 255u)
				{
					num5 = -1;
				}
				else
				{
					crnd_assert.Invoke(String_932ftxa.__pointer, String_yguirrd.__pointer, 2834);
					num5 = 0;
				}
				num3 = (int)((uint)(num3 * 15 + 128) / 255u);
			}
			else if ((uint)num3 <= 15u)
			{
				num6 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_azii4xc.__pointer, String_yguirrd.__pointer, 2837);
				num6 = 0;
			}
			num = (y << 1) + (x >>> 1);
			num2 = (byte)((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)num];
			((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)num] = (sbyte)((num2 & ((15 << ((x & 1) << 2)) ^ -1)) | (num3 << ((x & 1) << 2)));
		}
	}
}
