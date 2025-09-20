using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$destruct_array@Ublock_buffer_element@crn_unpacker@crnd@@@helpers@crnd@@YAXPEAUblock_buffer_element@crn_unpacker@1@I@Z")]
[DemangledName("void __cdecl crnd::helpers::destruct_array<struct crnd::crn_unpacker::block_buffer_element>(struct crnd::crn_unpacker::block_buffer_element *, unsigned int)")]
[CleanName("destruct_array")]
internal static partial class destruct_array_vfxflmb
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("struct crnd::crn_unpacker::block_buffer_element *")] void* p, [NativeType("unsigned int")] int n)
	{
		void* ptr = p;
		unchecked
		{
			for (void* ptr2 = (byte*)ptr + (nint)(uint)n * (nint)sizeof(crnd_crn_unpacker_block_buffer_element); ptr != ptr2; ptr = (byte*)ptr + sizeof(crnd_crn_unpacker_block_buffer_element))
			{
			}
		}
	}
}
