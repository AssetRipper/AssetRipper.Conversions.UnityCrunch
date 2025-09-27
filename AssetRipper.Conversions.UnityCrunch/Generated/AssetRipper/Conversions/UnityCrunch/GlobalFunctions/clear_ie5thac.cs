using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@decoder_tables@prefix_coding@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::prefix_coding::decoder_tables::clear(void)")]
[CleanName("clear")]
internal static partial class clear_ie5thac
{
	[return: NativeType("void")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((crnd_prefix_coding_decoder_tables*)@this)->m_lookup != null)
			{
				crnd_delete_array_nughn5d.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_lookup);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->m_lookup = null;
				((crnd_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size = 0;
			}
			if (((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order != null)
			{
				crnd_delete_array_rytswyc.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order);
				if (ExceptionInfo.Current == null)
				{
					((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = null;
					((crnd_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size = 0;
				}
			}
		}
	}
}
