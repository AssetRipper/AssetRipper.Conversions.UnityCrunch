using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clear@decoder_tables@prefix_coding@crnd@@QEAAXXZ")]
[DemangledName("public: void __cdecl crnd::prefix_coding::decoder_tables::clear(void)")]
[CleanName("clear")]
internal static partial class clear_ie5thac
{
	private partial struct LocalVariables
	{
	}

	public unsafe static void Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		unchecked
		{
			if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 != null)
			{
				crnd_delete_array_nughn5d.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_11 = null;
				((crnd_prefix_coding_decoder_tables*)@this)->field_10 = 0;
			}
			if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 != null)
			{
				crnd_delete_array_rytswyc.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_13);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_13 = null;
				((crnd_prefix_coding_decoder_tables*)@this)->field_12 = 0;
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
