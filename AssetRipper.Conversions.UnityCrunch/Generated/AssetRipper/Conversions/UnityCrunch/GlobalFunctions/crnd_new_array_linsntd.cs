using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_new_array@I@crnd@@YAPEAII@Z")]
[DemangledName("unsigned int * __cdecl crnd::crnd_new_array<unsigned int>(unsigned int)")]
[CleanName("crnd_new_array")]
internal static partial class crnd_new_array_linsntd
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public int field_1;

		public unsafe void* field_2;

		public unsafe void* field_3;
	}

	public unsafe static void* Invoke(int num)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = num;
		if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 == 0)
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 1;
		}
		unchecked
		{
			void* field_ = crnd_malloc.Invoke(8L + 4L * (long)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1, null);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_2 = field_;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_2 == null)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
			}
			else
			{
				void* field_2 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2 + 8;
				startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_2;
				int field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
				*(int*)((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_3 + -4) = field_3;
				int num2 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 ^ -1;
				*(int*)((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_3 + -8) = num2;
				construct_array_rijpqya.Invoke(n: startFrame.GetLocalsPointer<LocalVariables>()->field_1, p: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
				void* field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_4;
			}
			void* field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_5;
		}
	}
}
