using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0?$vector@I@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned int>::vector<unsigned int>(void)")]
internal static partial class vector_unsigned_int_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_vector_maaktjc*)@this)->field_0 = null;
			((crnd_vector_maaktjc*)@this)->field_1 = 0;
			((crnd_vector_maaktjc*)@this)->field_2 = 0;
			((crnd_vector_maaktjc*)@this)->field_3 = 0;
			return @this;
		}
	}
}
