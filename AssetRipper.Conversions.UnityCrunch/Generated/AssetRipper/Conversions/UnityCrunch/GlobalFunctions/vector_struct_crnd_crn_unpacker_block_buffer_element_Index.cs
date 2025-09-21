using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??A?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAAAEAUblock_buffer_element@crn_unpacker@1@I@Z")]
[DemangledName("public: struct crnd::crn_unpacker::block_buffer_element & __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::operator[](unsigned int)")]
internal static partial class vector_struct_crnd_crn_unpacker_block_buffer_element_Index
{
	[return: NativeType("struct crnd::crn_unpacker::block_buffer_element &")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned int")] int i)
	{
		unchecked
		{
			if ((uint)i >= (uint)((crnd_vector_y4ukjxd*)@this)->field_1)
			{
				crnd_assert.Invoke(String_ededlgd.__pointer, String_yguirrd.__pointer, 590);
			}
			return (byte*)((crnd_vector_y4ukjxd*)@this)->field_0 + (nint)(uint)i * (nint)sizeof(crnd_crn_unpacker_block_buffer_element);
		}
	}
}
