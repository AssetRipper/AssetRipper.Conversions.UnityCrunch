using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_2tt9kz
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size)
	{
		unchecked
		{
			if (((crnd_vector_v4kyxs*)@this)->m_size != new_size)
			{
				if ((uint)new_size < (uint)((crnd_vector_v4kyxs*)@this)->m_size)
				{
					destruct_array_5dg5zj.Invoke(n: ((crnd_vector_v4kyxs*)@this)->m_size - new_size, p: (byte*)((crnd_vector_v4kyxs*)@this)->m_p + (nint)(uint)new_size * (nint)sizeof(crnd_crn_unpacker_block_buffer_element));
				}
				else
				{
					if ((uint)new_size > (uint)((crnd_vector_v4kyxs*)@this)->m_capacity)
					{
						bool flag = increase_capacity_m62g7z.Invoke(@this, new_size, new_size == ((crnd_vector_v4kyxs*)@this)->m_size + 1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_jcwhf4.Invoke(n: new_size - ((crnd_vector_v4kyxs*)@this)->m_size, p: (byte*)((crnd_vector_v4kyxs*)@this)->m_p + (nint)(uint)((crnd_vector_v4kyxs*)@this)->m_size * (nint)sizeof(crnd_crn_unpacker_block_buffer_element));
				}
				((crnd_vector_v4kyxs*)@this)->m_size = new_size;
			}
			return true;
		}
	}
}
