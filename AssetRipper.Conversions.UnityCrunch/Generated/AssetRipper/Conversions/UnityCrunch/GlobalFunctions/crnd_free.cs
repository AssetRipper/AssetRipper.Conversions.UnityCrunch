using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_free@crnd@@YAXPEAX@Z")]
[DemangledName("void __cdecl crnd::crnd_free(void *)")]
internal static partial class crnd_free
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;
	}

	public unsafe static void Invoke(void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = p;
		unchecked
		{
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_0 != null)
			{
				if (((int)startFrame.GetLocalsPointer<LocalVariables>()->field_0 & 7) != 0)
				{
					crnd_mem_error.Invoke(String_gcwah5d.__pointer);
				}
				else
				{
					void* value = g_pRealloc.Value;
					void* value2 = g_pUser_data.Value;
					((delegate*<void*, long, void*, bool, void*, void*>)value)(startFrame.GetLocalsPointer<LocalVariables>()->field_0, 0L, null, true, value2);
					if (ExceptionInfo.Current != null)
					{
						return;
					}
				}
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
