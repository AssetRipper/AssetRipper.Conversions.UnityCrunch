using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::~vector<struct crnd::crn_unpacker::block_buffer_element>(void)")]
internal static partial class vector_struct_crnd_crn_unpacker_block_buffer_element_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		clear_jenxxsd.Invoke(@this);
		if (ExceptionInfo.Current == null)
		{
			return;
		}
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
