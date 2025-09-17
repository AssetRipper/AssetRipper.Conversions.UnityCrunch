using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_realloc@crnd@@YAPEAXPEAX_KPEA_K_N@Z")]
[DemangledName("void * __cdecl crnd::crnd_realloc(void *, unsigned __int64, unsigned __int64 *, bool)")]
internal static partial class crnd_realloc
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public sbyte field_1;

		public unsafe void* field_2;

		public long field_3;

		public unsafe void* field_4;

		public long field_5;

		public unsafe void* field_6;
	}

	public unsafe static void* Invoke(void* p, long size, void* pActual_size, bool movable)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = (movable ? ((sbyte)1) : ((sbyte)0));
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pActual_size;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = size;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = p;
		unchecked
		{
			if (((int)startFrame.GetLocalsPointer<LocalVariables>()->field_4 & 7) != 0)
			{
				crnd_mem_error.Invoke(String_ifury7b.__pointer);
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
			}
			else if ((ulong)startFrame.GetLocalsPointer<LocalVariables>()->field_3 > 2147418112uL)
			{
				crnd_mem_error.Invoke(String_ypy7scc.__pointer);
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
			}
			else
			{
				long field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
				startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				bool flag = (startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 1) == 1;
				long field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
				void* field_3 = ((delegate*<void*, long, long*, bool, void*, void*>)value)(startFrame.GetLocalsPointer<LocalVariables>()->field_4, field_2, &startFrame.GetLocalsPointer<LocalVariables>()->field_5, flag, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_3;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_2 != null)
				{
					long field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
					*(long*)startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_4;
				}
				int num;
				if (((int)startFrame.GetLocalsPointer<LocalVariables>()->field_6 & 7) == 0)
				{
					num = -1;
				}
				else
				{
					crnd_assert.Invoke(String_42humaa.__pointer, String_yguirrd.__pointer, 2039);
					num = 0;
				}
				void* field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_6;
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_5;
			}
			void* field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_6;
		}
	}
}
