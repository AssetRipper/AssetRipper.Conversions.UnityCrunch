using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vdecoder_tables@prefix_coding@crnd@@@crnd@@YAPEAVdecoder_tables@prefix_coding@0@AEBV120@@Z")]
[DemangledName("class crnd::prefix_coding::decoder_tables * __cdecl crnd::crnd_new<class crnd::prefix_coding::decoder_tables>(class crnd::prefix_coding::decoder_tables const &)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_vzd3zqa
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public unsafe void* field_1;

		public unsafe void* field_2;
	}

	public unsafe static void* Invoke(void* init)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = init;
		void* field_ = crnd_malloc.Invoke(192L, null);
		if (ExceptionInfo.Current != null)
		{
			return null;
		}
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_;
		if (startFrame.GetLocalsPointer<LocalVariables>()->field_2 == null)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		}
		else
		{
			void* field_2 = construct_zybj4yc.Invoke(init: startFrame.GetLocalsPointer<LocalVariables>()->field_1, p: startFrame.GetLocalsPointer<LocalVariables>()->field_2);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_2;
		}
		void* field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_3;
	}
}
