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
		sbyte b = (scaled ? ((sbyte)1) : ((sbyte)0));
		int num = value;
		unchecked
		{
			if ((uint)x >= 4u || (uint)y >= 4u)
			{
				crnd_assert.Invoke(String_cahur4b.__pointer, String_yguirrd.__pointer, 2831);
			}
			if ((b & 1) == 1)
			{
				if ((uint)num > 255u)
				{
					crnd_assert.Invoke(String_932ftxa.__pointer, String_yguirrd.__pointer, 2834);
				}
				num = (int)((uint)(num * 15 + 128) / 255u);
			}
			else if ((uint)num > 15u)
			{
				crnd_assert.Invoke(String_azii4xc.__pointer, String_yguirrd.__pointer, 2837);
			}
			int num2 = (y << 1) + (x >>> 1);
			int num3 = (byte)((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)num2];
			((sbyte*)(&((crnd_dxt3_block*)@this)->field_0))[(uint)num2] = (sbyte)((num3 & ((15 << ((x & 1) << 2)) ^ -1)) | (num << ((x & 1) << 2)));
		}
	}
}
