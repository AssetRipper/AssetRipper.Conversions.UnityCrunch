using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$construct_array@Ublock_buffer_element@crn_unpacker@crnd@@@helpers@crnd@@YAXPEAUblock_buffer_element@crn_unpacker@1@I@Z")]
[DemangledName("void __cdecl crnd::helpers::construct_array<struct crnd::crn_unpacker::block_buffer_element>(struct crnd::crn_unpacker::block_buffer_element *, unsigned int)")]
[CleanName("construct_array")]
internal static partial class construct_array_f9hrzwd
{
	public unsafe static void Invoke(void* p, int n)
	{
		void* ptr = null;
		void* ptr2 = null;
		ptr = p;
		unchecked
		{
			for (ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(crnd_crn_unpacker_block_buffer_element); ptr != ptr2; ptr = (byte*)ptr + sizeof(crnd_crn_unpacker_block_buffer_element))
			{
			}
		}
	}
}
