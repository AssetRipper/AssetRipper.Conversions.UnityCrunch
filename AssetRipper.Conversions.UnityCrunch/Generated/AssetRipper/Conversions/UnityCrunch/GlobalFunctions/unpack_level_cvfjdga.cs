using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_cvfjdga
{
	private partial struct LocalVariables
	{
		public int field_0;

		public int field_1;

		public int field_2;

		public unsafe void* field_3;

		public int field_4;

		public int field_5;
	}

	public unsafe static bool Invoke(void* @this, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = level_index;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = row_pitch_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = dst_size_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = pDst;
		unchecked
		{
			int field_ = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_20) + (nint)(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 * (nint)sizeof(crnd_crn_packed_uint_0));
			startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_;
			int field_2 = ((crnd_crn_unpacker*)@this)->field_2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_2;
			if ((uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 1) < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_7))
			{
				int field_3 = operator_unsigned_int_uxo4hgd.Invoke((byte*)(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_20) + (nint)(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 1) * (nint)sizeof(crnd_crn_packed_uint_0));
				startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_3;
			}
			int num;
			if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 > (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
			{
				num = -1;
			}
			else
			{
				crnd_assert.Invoke(String_huvyfmc.__pointer, String_yguirrd.__pointer, 2982);
				num = 0;
			}
			bool result = unpack_level_zjb72ec.Invoke(level_index: startFrame.GetLocalsPointer<LocalVariables>()->field_0, row_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, dst_size_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_2, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3, src_size_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_5 - startFrame.GetLocalsPointer<LocalVariables>()->field_4, @this: @this, pSrc: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
