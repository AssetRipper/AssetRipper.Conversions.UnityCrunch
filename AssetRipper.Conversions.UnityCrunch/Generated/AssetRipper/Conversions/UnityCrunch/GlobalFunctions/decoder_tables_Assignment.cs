using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4decoder_tables@prefix_coding@crnd@@QEAAAEAV012@AEBV012@@Z")]
[DemangledName("public: class crnd::prefix_coding::decoder_tables & __cdecl crnd::prefix_coding::decoder_tables::operator=(class crnd::prefix_coding::decoder_tables const &)")]
internal static partial class decoder_tables_Assignment
{
	[return: NativeType("class crnd::prefix_coding::decoder_tables &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class crnd::prefix_coding::decoder_tables const &")] void* other)
	{
		if (@this == other)
		{
			return @this;
		}
		clear_v2azth.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		llvm_memcpy_p0_p0_i64.Invoke(@this, other, 192L, isVolatile: false);
		unchecked
		{
			if (((crnd_prefix_coding_decoder_tables*)other)->m_lookup != null)
			{
				void* lookup = crnd_new_array_zqdtgg.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->m_lookup = lookup;
				if (((crnd_prefix_coding_decoder_tables*)@this)->m_lookup != null)
				{
					llvm_memcpy_p0_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_lookup, ((crnd_prefix_coding_decoder_tables*)other)->m_lookup, 4L * (long)(uint)((crnd_prefix_coding_decoder_tables*)@this)->m_cur_lookup_size, isVolatile: false);
				}
			}
			if (((crnd_prefix_coding_decoder_tables*)other)->m_sorted_symbol_order != null)
			{
				void* sorted_symbol_order = crnd_new_array_ped3ba.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order = sorted_symbol_order;
				if (((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order != null)
				{
					llvm_memcpy_p0_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->m_sorted_symbol_order, ((crnd_prefix_coding_decoder_tables*)other)->m_sorted_symbol_order, 2L * (long)(uint)((crnd_prefix_coding_decoder_tables*)@this)->m_cur_sorted_symbol_order_size, isVolatile: false);
				}
			}
			return @this;
		}
	}
}
