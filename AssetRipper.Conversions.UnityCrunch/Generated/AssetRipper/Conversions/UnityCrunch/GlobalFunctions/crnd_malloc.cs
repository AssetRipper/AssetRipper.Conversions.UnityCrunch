using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_malloc@crnd@@YAPEAX_KPEA_K@Z")]
[DemangledName("void * __cdecl crnd::crnd_malloc(unsigned __int64, unsigned __int64 *)")]
internal static partial class crnd_malloc
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public unsafe void* field_1;

		public long field_2;

		public long field_3;

		public unsafe void* field_4;
	}

	public unsafe static void* Invoke(long size, void* pActual_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0L;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = pActual_size;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = size;
		unchecked
		{
			long field_ = (startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 4L - 1L) & -4L;
			startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_2 == 0L)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 4L;
			}
			if ((ulong)startFrame.GetLocalsPointer<LocalVariables>()->field_2 > 2147418112uL)
			{
				crnd_mem_error.Invoke(String_ypy7scc.__pointer);
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
			}
			else
			{
				long field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_2;
				startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_2;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* field_3 = ((delegate*<void*, long, long*, bool, void*, void*>)value)(null, startFrame.GetLocalsPointer<LocalVariables>()->field_2, &startFrame.GetLocalsPointer<LocalVariables>()->field_3, true, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_3;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 != null)
				{
					long field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
					*(long*)startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_4;
				}
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_4 == null || (ulong)startFrame.GetLocalsPointer<LocalVariables>()->field_3 < (ulong)startFrame.GetLocalsPointer<LocalVariables>()->field_2)
				{
					crnd_mem_error.Invoke(String_xewaojb.__pointer);
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
				}
				else
				{
					int num;
					if (((int)startFrame.GetLocalsPointer<LocalVariables>()->field_4 & 7) == 0)
					{
						num = -1;
					}
					else
					{
						crnd_assert.Invoke(String_42humaa.__pointer, String_yguirrd.__pointer, 2017);
						num = 0;
					}
					void* field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_4;
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_5;
				}
			}
			void* field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_6;
		}
	}
}
