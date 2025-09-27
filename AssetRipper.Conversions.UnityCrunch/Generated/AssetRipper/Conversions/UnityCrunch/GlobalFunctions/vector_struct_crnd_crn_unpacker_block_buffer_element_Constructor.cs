using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::vector<struct crnd::crn_unpacker::block_buffer_element>(void)")]
internal static partial class vector_struct_crnd_crn_unpacker_block_buffer_element_Constructor
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_vector_y4ukjxd*)@this)->m_p = null;
			((crnd_vector_y4ukjxd*)@this)->m_size = 0;
			((crnd_vector_y4ukjxd*)@this)->m_capacity = 0;
			((crnd_vector_y4ukjxd*)@this)->m_alloc_failed = 0;
			return @this;
		}
	}
}
