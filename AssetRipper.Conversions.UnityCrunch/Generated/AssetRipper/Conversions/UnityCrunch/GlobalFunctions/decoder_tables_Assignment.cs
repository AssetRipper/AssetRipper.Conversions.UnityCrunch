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
		void* ptr = null;
		if (@this == other)
		{
			return @this;
		}
		clear_ie5thac.Invoke(@this);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		llvm_memcpy_p0_p0_i64.Invoke(@this, other, 192L, isVolatile: false);
		unchecked
		{
			if (((crnd_prefix_coding_decoder_tables*)other)->field_11 != null)
			{
				void* field_ = crnd_new_array_linsntd.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_10);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_11 = field_;
				if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 != null)
				{
					llvm_memcpy_p0_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11, ((crnd_prefix_coding_decoder_tables*)other)->field_11, 4L * (long)(uint)((crnd_prefix_coding_decoder_tables*)@this)->field_10, isVolatile: false);
				}
			}
			if (((crnd_prefix_coding_decoder_tables*)other)->field_13 != null)
			{
				void* field_2 = crnd_new_array_ovofsdb.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_12);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_13 = field_2;
				if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 != null)
				{
					llvm_memcpy_p0_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_13, ((crnd_prefix_coding_decoder_tables*)other)->field_13, 2L * (long)(uint)((crnd_prefix_coding_decoder_tables*)@this)->field_12, isVolatile: false);
				}
			}
			return @this;
		}
	}
}
