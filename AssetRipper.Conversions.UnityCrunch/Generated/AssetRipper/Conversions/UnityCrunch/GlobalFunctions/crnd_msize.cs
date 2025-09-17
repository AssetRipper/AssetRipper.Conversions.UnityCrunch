using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_msize@crnd@@YA_KPEAX@Z")]
[DemangledName("unsigned __int64 __cdecl crnd::crnd_msize(void *)")]
internal static partial class crnd_msize
{
	private partial struct LocalVariables
	{
		public long field_0;

		public unsafe void* field_1;
	}

	public unsafe static long Invoke(void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = p;
		unchecked
		{
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 == null)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
			}
			else if (((int)startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 7) != 0)
			{
				crnd_mem_error.Invoke(String_zijibvd.__pointer);
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0L;
			}
			else
			{
				void* value = g_pMSize.Value;
				void* value2 = g_pUser_data.Value;
				long field_ = ((delegate*<void*, void*, long>)value)(startFrame.GetLocalsPointer<LocalVariables>()->field_1, value2);
				if (ExceptionInfo.Current != null)
				{
					return 0L;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_;
			}
			long field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_2;
		}
	}
}
