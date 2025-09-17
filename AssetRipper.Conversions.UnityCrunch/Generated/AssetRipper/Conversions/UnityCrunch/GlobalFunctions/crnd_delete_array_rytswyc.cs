using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??$crnd_delete_array@G@crnd@@YAXPEAG@Z")]
[DemangledName("void __cdecl crnd::crnd_delete_array<unsigned short>(unsigned short *)")]
[CleanName("crnd_delete_array")]
internal static partial class crnd_delete_array_rytswyc
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public int field_1;
	}

	public unsafe static void Invoke(void* p)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = p;
		unchecked
		{
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_0 != null)
			{
				int field_ = *(int*)((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + -4);
				startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
				int num;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 != 0 && startFrame.GetLocalsPointer<LocalVariables>()->field_1 == (*(int*)((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + -8) ^ -1))
				{
					num = -1;
				}
				else
				{
					crnd_assert.Invoke(String_zzvckkc.__pointer, String_yguirrd.__pointer, 347);
					num = 0;
				}
				destruct_array_viasmsc.Invoke(n: startFrame.GetLocalsPointer<LocalVariables>()->field_1, p: startFrame.GetLocalsPointer<LocalVariables>()->field_0);
				crnd_free.Invoke((byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_0 + -8);
				if (ExceptionInfo.Current != null)
				{
					return;
				}
			}
			StackFrameList.Current.Clear(startFrame);
		}
	}
}
