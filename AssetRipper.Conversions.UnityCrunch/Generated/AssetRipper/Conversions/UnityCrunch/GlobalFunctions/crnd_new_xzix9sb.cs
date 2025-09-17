using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new@Vcrn_unpacker@crnd@@@crnd@@YAPEAVcrn_unpacker@0@XZ")]
[DemangledName("class crnd::crn_unpacker * __cdecl crnd::crnd_new<class crnd::crn_unpacker>(void)")]
[CleanName("crnd_new")]
internal static partial class crnd_new_xzix9sb
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
		void* field_ = crnd_malloc.Invoke(392L, null);
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
			void* field_2 = construct_bzfae7a.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_1);
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
