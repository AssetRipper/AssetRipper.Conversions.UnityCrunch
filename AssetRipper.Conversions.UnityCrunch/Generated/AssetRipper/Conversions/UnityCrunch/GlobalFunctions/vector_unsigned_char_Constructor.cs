using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0?$vector@E@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<unsigned char>::vector<unsigned char>(void)")]
internal static partial class vector_unsigned_char_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_vector*)@this)->field_0 = null;
			((crnd_vector*)@this)->field_1 = 0;
			((crnd_vector*)@this)->field_2 = 0;
			((crnd_vector*)@this)->field_3 = 0;
			return @this;
		}
	}
}
