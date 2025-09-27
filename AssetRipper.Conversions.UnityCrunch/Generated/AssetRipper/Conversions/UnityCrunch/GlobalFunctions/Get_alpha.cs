using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_alpha@dxt3_block@crnd@@QEBAIII_N@Z")]
[DemangledName("public: unsigned int __cdecl crnd::dxt3_block::get_alpha(unsigned int, unsigned int, bool) const")]
internal static partial class Get_alpha
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned int")] int x, [NativeType("unsigned int")] int y, [NativeType("bool")] bool scaled)
	{
		sbyte b = (scaled ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			if ((uint)x >= 4u || (uint)y >= 4u)
			{
				crnd_assert.Invoke(String_cahur4b.__pointer, String_yguirrd.__pointer, 2850);
			}
			int num = (byte)((sbyte*)(&((crnd_dxt3_block*)@this)->m_alpha))[(uint)((y << 1) + (x >>> 1))];
			if ((x & 1) != 0)
			{
				num >>>= 4;
			}
			num &= 0xF;
			if ((b & 1) == 1)
			{
				num = (num << 4) | num;
			}
			return num;
		}
	}
}
