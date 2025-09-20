using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_malloc@crnd@@YAPEAX_KPEA_K@Z")]
[DemangledName("void * __cdecl crnd::crnd_malloc(unsigned __int64, unsigned __int64 *)")]
internal static partial class crnd_malloc
{
	private partial struct LocalVariables
	{
		public long field_0;
	}

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		void* ptr = null;
		localsPointer->field_0 = 0L;
		void* ptr2 = null;
		unchecked
		{
			long num = (size + 4L - 1L) & -4L;
			if (num == 0L)
			{
				num = 4L;
			}
			if ((ulong)num > 2147418112uL)
			{
				crnd_mem_error.Invoke(String_ypy7scc.__pointer);
				ptr = null;
			}
			else
			{
				localsPointer->field_0 = num;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* ptr3 = ((delegate*<void*, long, long*, bool, void*, void*>)value)(null, num, &localsPointer->field_0, true, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ptr2 = ptr3;
				if (pActual_size != null)
				{
					*(long*)pActual_size = localsPointer->field_0;
				}
				if (ptr2 == null || (ulong)localsPointer->field_0 < (ulong)num)
				{
					crnd_mem_error.Invoke(String_xewaojb.__pointer);
					ptr = null;
				}
				else
				{
					int num2;
					if (((int)ptr2 & 7) == 0)
					{
						num2 = -1;
					}
					else
					{
						crnd_assert.Invoke(String_42humaa.__pointer, String_yguirrd.__pointer, 2017);
						num2 = 0;
					}
					ptr = ptr2;
				}
			}
			void* result = ptr;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
