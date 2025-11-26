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
			((crnd_vector_h6df48*)@this)->m_p = null;
			((crnd_vector_h6df48*)@this)->m_size = 0;
			((crnd_vector_h6df48*)@this)->m_capacity = 0;
			((crnd_vector_h6df48*)@this)->m_alloc_failed = 0;
			return @this;
		}
	}
}
