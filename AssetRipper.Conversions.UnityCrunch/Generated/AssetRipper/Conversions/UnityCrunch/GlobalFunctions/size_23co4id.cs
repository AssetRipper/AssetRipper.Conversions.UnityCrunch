using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?size@?$vector@E@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::vector<unsigned char>::size(void) const")]
[CleanName("size")]
internal static partial class size_23co4id
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_vector_f3cmzmc*)@this)->field_1;
	}
}
