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
		localsPointer->field_0 = 0L;
		sbyte b = (movable ? ((sbyte)1) : ((sbyte)0));
		unchecked
		{
			void* ptr;
			if (((int)p & 7) != 0)
			{
				crnd_mem_error.Invoke(String_f3peyu.__pointer);
				ptr = null;
			}
			else if ((ulong)size > 2147418112uL)
			{
				crnd_mem_error.Invoke(String_mqjrcv.__pointer);
				ptr = null;
			}
			else
			{
				localsPointer->field_0 = size;
				void* value = g_pRealloc.Value;
				void* value2 = g_pUser_data.Value;
				void* ptr2 = ((delegate*<void*, long, long*, bool, void*, void*>)value)(p, size, &localsPointer->field_0, (b & 1) == 1, value2);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				void* ptr3 = ptr2;
				if (pActual_size != null)
				{
					*(long*)pActual_size = localsPointer->field_0;
				}
				if (((int)ptr3 & 7) != 0)
				{
					crnd_assert.Invoke(String_7eewk9.__pointer, String_vvx8bt.__pointer, 2039);
				}
				ptr = ptr3;
			}
			void* result = ptr;
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
