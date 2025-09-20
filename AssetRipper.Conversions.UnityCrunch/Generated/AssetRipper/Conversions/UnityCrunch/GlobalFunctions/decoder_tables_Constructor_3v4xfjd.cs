using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0decoder_tables@prefix_coding@crnd@@QEAA@AEBV012@@Z")]
[DemangledName("public: __cdecl crnd::prefix_coding::decoder_tables::decoder_tables(class crnd::prefix_coding::decoder_tables const &)")]
[CleanName("decoder_tables_Constructor")]
internal static partial class decoder_tables_Constructor_3v4xfjd
{
	public unsafe static void* Invoke(void* @this, [NativeType("class crnd::prefix_coding::decoder_tables const &")] void* other)
	{
		unchecked
		{
			((crnd_prefix_coding_decoder_tables*)@this)->field_10 = 0;
			((crnd_prefix_coding_decoder_tables*)@this)->field_11 = null;
			((crnd_prefix_coding_decoder_tables*)@this)->field_12 = 0;
			((crnd_prefix_coding_decoder_tables*)@this)->field_13 = null;
			decoder_tables_Assignment.Invoke(@this, other);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			return @this;
		}
	}
}
