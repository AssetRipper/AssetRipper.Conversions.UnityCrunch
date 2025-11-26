using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_hv5vjw
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_v4kyxs*)@this)->m_p != null)
			{
				destruct_array_5dg5zj.Invoke(n: ((crnd_vector_v4kyxs*)@this)->m_size, p: ((crnd_vector_v4kyxs*)@this)->m_p);
				crnd_free.Invoke(((crnd_vector_v4kyxs*)@this)->m_p);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_v4kyxs*)@this)->m_p = null;
				((crnd_vector_v4kyxs*)@this)->m_size = 0;
				((crnd_vector_v4kyxs*)@this)->m_capacity = 0;
			}
			((crnd_vector_v4kyxs*)@this)->m_alloc_failed = 0;
		}
	}
}
