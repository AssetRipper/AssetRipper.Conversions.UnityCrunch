using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@?$vector@Ublock_buffer_element@crn_unpacker@crnd@@@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::vector<struct crnd::crn_unpacker::block_buffer_element>::clear(void)")]
[CleanName("clear")]
internal static partial class clear_jenxxsd
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_vector_y4ukjxd*)@this)->field_0 != null)
			{
				destruct_array_h3fegud.Invoke(n: ((crnd_vector_y4ukjxd*)@this)->field_1, p: ((crnd_vector_y4ukjxd*)@this)->field_0);
				crnd_free.Invoke(((crnd_vector_y4ukjxd*)@this)->field_0);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_vector_y4ukjxd*)@this)->field_0 = null;
				((crnd_vector_y4ukjxd*)@this)->field_1 = 0;
				((crnd_vector_y4ukjxd*)@this)->field_2 = 0;
			}
			((crnd_vector_y4ukjxd*)@this)->field_3 = 0;
		}
	}
}
