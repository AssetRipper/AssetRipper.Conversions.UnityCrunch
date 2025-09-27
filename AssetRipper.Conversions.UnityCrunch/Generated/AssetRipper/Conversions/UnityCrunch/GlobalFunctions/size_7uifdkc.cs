using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?size@?$vector@I@crnd@@QEBAIXZ")]
[DemangledName("public: unsigned int __cdecl crnd::vector<unsigned int>::size(void) const")]
[CleanName("size")]
internal static partial class size_7uifdkc
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((crnd_vector_maaktjc*)@this)->m_size;
	}
}
