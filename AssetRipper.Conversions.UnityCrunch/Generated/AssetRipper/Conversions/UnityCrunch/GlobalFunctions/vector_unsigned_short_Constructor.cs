using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0?$vector@G@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned short>::vector<unsigned short>(void)")]
internal static partial class vector_unsigned_short_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_vector_rf9iywd*)@this)->field_0 = null;
			((crnd_vector_rf9iywd*)@this)->field_1 = 0;
			((crnd_vector_rf9iywd*)@this)->field_2 = 0;
			((crnd_vector_rf9iywd*)@this)->field_3 = 0;
			return @this;
		}
	}
}
