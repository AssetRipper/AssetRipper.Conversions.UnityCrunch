using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_kfwzjla
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size)
	{
		bool flag = false;
		unchecked
		{
			if (((crnd_vector_y4ukjxd*)@this)->field_1 != new_size)
			{
				if ((uint)new_size < (uint)((crnd_vector_y4ukjxd*)@this)->field_1)
				{
					destruct_array_h3fegud.Invoke(n: ((crnd_vector_y4ukjxd*)@this)->field_1 - new_size, p: (byte*)((crnd_vector_y4ukjxd*)@this)->field_0 + (nint)(uint)new_size * (nint)sizeof(crnd_crn_unpacker_block_buffer_element));
				}
				else
				{
					if ((uint)new_size > (uint)((crnd_vector_y4ukjxd*)@this)->field_2)
					{
						bool flag2 = increase_capacity_ucojcwb.Invoke(@this, new_size, new_size == ((crnd_vector_y4ukjxd*)@this)->field_1 + 1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag2)
						{
							return false;
						}
					}
					construct_array_5afuwda.Invoke(n: new_size - ((crnd_vector_y4ukjxd*)@this)->field_1, p: (byte*)((crnd_vector_y4ukjxd*)@this)->field_0 + (nint)(uint)((crnd_vector_y4ukjxd*)@this)->field_1 * (nint)sizeof(crnd_crn_unpacker_block_buffer_element));
				}
				((crnd_vector_y4ukjxd*)@this)->field_1 = new_size;
			}
			return true;
		}
	}
}
