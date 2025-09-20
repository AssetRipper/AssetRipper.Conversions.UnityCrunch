using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?increase_capacity@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@AEAA_NI_N@Z")]
[DemangledName("private: bool __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::increase_capacity(unsigned int, bool)")]
[CleanName("increase_capacity")]
internal static partial class increase_capacity_ucojcwb
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int min_new_capacity, [NativeType("bool")] bool grow_hint)
	{
		bool flag = false;
		bool flag2 = increase_capacity_nb7lc5b.Invoke(@this, min_new_capacity, ((grow_hint ? 1u : 0u) & 1u) == 1, 8, null);
		if (ExceptionInfo.Current != null)
		{
			return false;
		}
		if (!flag2)
		{
			unchecked((crnd_vector_y4ukjxd*)@this)->field_3 = 1;
			return false;
		}
		return true;
	}
}
