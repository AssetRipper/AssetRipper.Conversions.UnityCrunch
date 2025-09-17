using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAAAEAUblock_buffer_element@crn_unpacker@1@I@Z")]
[DemangledName("public: struct crnd::crn_unpacker::block_buffer_element & __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::operator[](unsigned int)")]
[CleanName("Index")]
internal static partial class Index_97utgsc
{
	public unsafe static void* Invoke(void* @this, int i)
	{
		int num = 0;
		num = i;
		unchecked
		{
			int num2;
			if ((uint)num < (uint)((crnd_vector_11*)@this)->field_1)
			{
				num2 = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 590);
				num2 = 0;
			}
			return (byte*)((crnd_vector_11*)@this)->field_0 + (nint)(uint)num * (nint)sizeof(crnd_crn_unpacker_block_buffer_element);
		}
	}
}
