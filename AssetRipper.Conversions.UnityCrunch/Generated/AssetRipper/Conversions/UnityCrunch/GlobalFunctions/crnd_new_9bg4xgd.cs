using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAPEAVdecoder_tables@prefix_coding@0@XZ")]
[DemangledName("class crnd::prefix_coding::decoder_tables * __cdecl crnd::crnd_new<class crnd::prefix_coding::decoder_tables>(void)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_9bg4xgd
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public unsafe void* field_1;
	}

	public unsafe static void* Invoke()
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		void* field_ = crnd_malloc.Invoke(192L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
		if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 == null)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		}
		else
		{
			void* field_2 = construct_e5fhx3a.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_1);
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_2;
		}
		void* field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_3;
	}
}
