using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1decoder_tables@prefix_coding@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::prefix_coding::decoder_tables::~decoder_tables(void)")]
internal static partial class decoder_tables_Destructor
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_prefix_coding_decoder_tables*)@this)->m_lookup != null)
			{
				crnd_delete_array_nughn5d.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_lookup);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0051;
				}
			}
			if (((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order == null)
			{
				return;
			}
			crnd_delete_array_rytswyc.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order);
			if (ExceptionInfo.Current == null)
			{
				return;
			}
			goto IL_0051;
		}
		IL_0051:
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
