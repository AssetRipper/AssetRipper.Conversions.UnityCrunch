using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??1decoder_tables@prefix_coding@crnd@@QEAA@XZ")]
[DemangledName("public: __cdecl crnd::prefix_coding::decoder_tables::~decoder_tables(void)")]
internal static partial class decoder_tables_Destructor
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
					goto IL_0067;
				}
			}
			if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 != null)
			{
				crnd_delete_array_rytswyc.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_13);
				if (ExceptionInfo.Current != null)
				{
					goto IL_0067;
				}
			}
			StackFrameList.Current.Clear(startFrame);
			return;
		}
		IL_0067:
		ExceptionInfo.Current = null;
		std_terminate.Invoke();
		throw null;
	}
}
