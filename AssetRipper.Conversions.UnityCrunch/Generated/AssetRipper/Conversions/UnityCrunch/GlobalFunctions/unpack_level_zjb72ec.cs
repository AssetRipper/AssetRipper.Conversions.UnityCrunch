using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEBXIPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void const *, unsigned int, void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_zjb72ec
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public int field_2;

		public unsafe void* field_3;

		public int field_4;

		public unsafe void* field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public int field_9;

		public sbyte field_10;

		public int field_11;

		public int field_12;
	}

	public unsafe static bool Invoke(void* @this, void* pSrc, int src_size_in_bytes, void* pDst, int dst_size_in_bytes, int row_pitch_in_bytes, int level_index)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = level_index;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = row_pitch_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = dst_size_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = pDst;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = src_size_in_bytes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = pSrc;
		unchecked
		{
			int field_ = maximum.Invoke(operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_5) >>> startFrame.GetLocalsPointer<LocalVariables>()->field_11, 1);
			startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_;
			int num = maximum.Invoke(operator_unsigned_int_f3crpsb.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_6) >>> startFrame.GetLocalsPointer<LocalVariables>()->field_11, 1);
			int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_12 + 3 >>> 2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_7 = num + 3 >>> 2;
			bool flag = ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 0) ? true : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 9) ? true : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? true : ((operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? (operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 13) : true))));
			_ = flag;
			int field_3 = InstructionHelper.Select(flag, 8, 16);
			startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_3;
			int field_4 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 * startFrame.GetLocalsPointer<LocalVariables>()->field_6;
			startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_4;
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 == 0)
			{
				int field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_9;
				startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_5;
			}
			else if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9 || (startFrame.GetLocalsPointer<LocalVariables>()->field_1 & 3) != 0)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				goto IL_0735;
			}
			if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_2 < (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_1 * startFrame.GetLocalsPointer<LocalVariables>()->field_7))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: startFrame.GetLocalsPointer<LocalVariables>()->field_4, pBuf: startFrame.GetLocalsPointer<LocalVariables>()->field_5))
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
				int num2 = operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9);
				if (num2 != 0 && num2 != 13)
				{
					if (num2 != 2 && num2 != 3 && num2 != 5 && num2 != 6 && num2 != 4 && num2 != 14)
					{
						if (num2 != 9)
						{
							if (num2 != 7 && num2 != 8)
							{
								if (num2 != 10)
								{
									if (num2 != 11)
									{
										if (num2 != 12)
										{
											startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
											goto IL_0735;
										}
										bool flag2 = unpack_etc2a.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, output_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag2 ? ((sbyte)1) : ((sbyte)0));
									}
									else
									{
										bool flag3 = unpack_etc1.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, output_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
										if (ExceptionInfo.Current != null)
										{
											return false;
										}
										startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag3 ? ((sbyte)1) : ((sbyte)0));
									}
								}
								else
								{
									bool flag4 = unpack_etc1.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, output_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
									if (ExceptionInfo.Current != null)
									{
										return false;
									}
									startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag4 ? ((sbyte)1) : ((sbyte)0));
								}
							}
							else
							{
								bool flag5 = unpack_dxn.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, row_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
								if (ExceptionInfo.Current != null)
								{
									return false;
								}
								startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag5 ? ((sbyte)1) : ((sbyte)0));
							}
						}
						else
						{
							bool flag6 = unpack_dxt5a.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, row_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag6 ? ((sbyte)1) : ((sbyte)0));
						}
					}
					else
					{
						bool flag7 = unpack_dxt5.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, row_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag7 ? ((sbyte)1) : ((sbyte)0));
					}
				}
				else
				{
					bool flag8 = unpack_dxt1.Invoke(output_height: startFrame.GetLocalsPointer<LocalVariables>()->field_7, output_width: startFrame.GetLocalsPointer<LocalVariables>()->field_6, output_pitch_in_bytes: startFrame.GetLocalsPointer<LocalVariables>()->field_1, @this: @this, pDst: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (flag8 ? ((sbyte)1) : ((sbyte)0));
				}
				if ((startFrame.GetLocalsPointer<LocalVariables>()->field_10 & 1) != 1)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else
				{
					stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
				}
			}
			goto IL_0735;
		}
		IL_0735:
		bool field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_6;
	}
}
