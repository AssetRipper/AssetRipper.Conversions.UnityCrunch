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
			((crnd_vector_rgfndh*)@this)->m_p = null;
			((crnd_vector_rgfndh*)@this)->m_size = 0;
			((crnd_vector_rgfndh*)@this)->m_capacity = 0;
			((crnd_vector_rgfndh*)@this)->m_alloc_failed = 0;
			return @this;
		}
	}
}
