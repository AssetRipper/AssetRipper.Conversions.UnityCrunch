using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0decoder_tables@prefix_coding@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::prefix_coding::decoder_tables::decoder_tables(void)")]
[CleanName("decoder_tables_Constructor")]
internal static partial class decoder_tables_Constructor_2o5uqyd
{
	public unsafe static void* Invoke(void* @this)
	{
		unchecked
		{
			((crnd_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size = 0;
			((crnd_prefix_coding_decoder_tables*)@this)->m_lookup = null;
			((crnd_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size = 0;
			((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = null;
			return @this;
		}
	}
}
