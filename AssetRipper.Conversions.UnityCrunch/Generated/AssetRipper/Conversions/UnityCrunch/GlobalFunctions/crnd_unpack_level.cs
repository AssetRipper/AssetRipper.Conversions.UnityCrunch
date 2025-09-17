using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_unpack_level@crnd@@YA_NPEAXPEAPEAXIII@Z")]
[DemangledName("bool __cdecl crnd::crnd_unpack_level(void *, void **, unsigned int, unsigned int, unsigned int)")]
internal static partial class crnd_unpack_level
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public int field_2;

		public int field_3;

		public unsafe void* field_4;

		public unsafe void* field_5;

		public unsafe void* field_6;
	}

	public unsafe static bool Invoke(void* pContext, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = level_index;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = row_pitch_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = dst_size_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = pDst;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = pContext;
		if (unchecked(startFrame.GetLocalsPointer<LocalVariables>()->field_5 == null || startFrame.GetLocalsPointer<LocalVariables>()->field_4 == null || (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 < 8u || (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 >= 16u))
		{
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		}
		else
		{
			void* field_ = startFrame.GetLocalsPointer<LocalVariables>()->field_5;
			startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_;
			if (!is_valid.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_6))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				bool field_2 = unpack_level_cvfjdga.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_6, level_index: startFrame.GetLocalsPointer<LocalVariables>()->field_1, row_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_2, dst_size_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_3, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_4);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_2;
			}
		}
		bool field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_3;
	}
}
