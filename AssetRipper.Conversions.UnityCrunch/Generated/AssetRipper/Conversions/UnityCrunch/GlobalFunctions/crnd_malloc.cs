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
		localsPointer->field_0 = 0L;
		unchecked
		{
			long num = (size + 4L - 1L) & -4L;
			if (num == 0L)
			{
				num = 4L;
			}
			void* ptr;
			if ((ulong)num > 2147418112uL)
			{
				crnd_mem_error.Invoke(String_mqjrcv.__pointer);
				ptr = null;
			}
			else
			{
				localsPointer->field_0 = num;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* ptr2 = ((delegate*<void*, long, long*, bool, void*, void*>)value)(null, num, &localsPointer->field_0, true, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				void* ptr3 = ptr2;
				if (pActual_size != null)
				{
					*(long*)pActual_size = localsPointer->field_0;
				}
				if (ptr3 == null || (ulong)localsPointer->field_0 < (ulong)num)
				{
					crnd_mem_error.Invoke(String_eafej9.__pointer);
					ptr = null;
				}
				else
				{
					if (((int)ptr3 & 7) != 0)
					{
						crnd_assert.Invoke(String_7eewk9.__pointer, String_vvx8bt.__pointer, 2017);
					}
					ptr = ptr3;
				}
			}
			void* result = ptr;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
