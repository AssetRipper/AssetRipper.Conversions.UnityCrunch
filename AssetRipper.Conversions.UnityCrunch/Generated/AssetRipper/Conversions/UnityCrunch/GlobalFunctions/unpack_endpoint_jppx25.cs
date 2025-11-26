using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_endpoint@dxt5_block@crnd@@SAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::unpack_endpoint(unsigned int, unsigned int)")]
[CleanName("unpack_endpoint")]
internal static partial class unpack_endpoint_jppx25
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int")] int packed, [NativeType("unsigned int")] int index)
	{
		unchecked
		{
			if ((uint)index >= 2u)
			{
				crnd_assert.Invoke(String_6s4rgc.__pointer, String_vvx8bt.__pointer, 2919);
			}
			return (packed >>> 8 * index) & 0xFF;
		}
	}
}
