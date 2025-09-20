using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_realloc@crnd@@YAPEAXPEAX_KPEA_K_N@Z")]
[DemangledName("void * __cdecl crnd::crnd_realloc(void *, unsigned __int64, unsigned __int64 *, bool)")]
internal static partial class crnd_realloc
{
	private partial struct LocalVariables
	{
		public long field_0;
	}

	[return: NativeType("void *")]
	public unsafe static void* Invoke([NativeType("void *")] void* p, [NativeType("unsigned __int64")] long size, [NativeType("unsigned __int64 *")] void* pActual_size, [NativeType("bool")] bool movable)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		void* ptr = null;
		localsPointer->field_0 = 0L;
		void* ptr2 = null;
		sbyte b = (movable ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			if (((int)p & 7) != 0)
			{
				crnd_mem_error.Invoke(String_ifury7b.__pointer);
				ptr = null;
			}
			else if ((ulong)size > 2147418112uL)
			{
				crnd_mem_error.Invoke(String_ypy7scc.__pointer);
				ptr = null;
			}
			else
			{
				localsPointer->field_0 = size;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* ptr3 = ((delegate*<void*, long, long*, bool, void*, void*>)value)(p, size, &localsPointer->field_0, (b & 1) == 1, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				ptr2 = ptr3;
				if (pActual_size != null)
				{
					*(long*)pActual_size = localsPointer->field_0;
				}
				int num;
				if (((int)ptr2 & 7) == 0)
				{
					num = -1;
				}
				else
				{
					crnd_assert.Invoke(String_42humaa.__pointer, String_yguirrd.__pointer, 2039);
					num = 0;
				}
				ptr = ptr2;
			}
			void* result = ptr;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
