using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_end@crnd@@YA_NPEAX@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_end(void *)")]
internal static partial class crnd_unpack_end
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public unsafe void* field_1;

		public unsafe void* field_2;
	}

	public unsafe static bool Invoke(void* pContext)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = pContext;
		if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 == null)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		else
		{
			void* field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
			startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_;
			if (!is_valid.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_2))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				crnd_delete_e7rwdhb.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_2);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			}
		}
		bool field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_2;
	}
}
