using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_etc1@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_etc1(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_etc1
{
	private partial struct LocalVariables
	{
		public int field_0;

		public int field_1;

		public unsafe void* field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int field_6;

		public int field_7;

		public int field_8;

		public sbyte field_9;

		public int field_10;

		public unsafe void* field_11;

		public int field_12;

		public sbyte field_13;

		public int field_14;

		public unsafe void* field_15;

		public sbyte field_16;

		public InlineArray_4_w3otm9c field_17;

		public InlineArray_4_w3otm9c field_18;

		public InlineArray_4_w3otm9c field_19;

		public int field_20;

		public int field_21;

		public int field_22;

		public int field_23;

		public int field_24;
	}

	public unsafe static bool Invoke(void* @this, void* pDst, int output_pitch_in_bytes, int output_width, int output_height)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_17 = default(InlineArray_4_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_18 = default(InlineArray_4_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_19 = default(InlineArray_4_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_20 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_21 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_22 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_23 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_24 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = output_height;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = output_width;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pDst;
		unchecked
		{
			int field_ = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_;
			int field_2 = (startFrame.GetLocalsPointer<LocalVariables>()->field_1 + 1) & -2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_2;
			int field_3 = (startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 1) & -2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_3;
			int field_4 = (output_pitch_in_bytes >>> 2) - (startFrame.GetLocalsPointer<LocalVariables>()->field_4 << 1);
			startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_4;
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_4 << 1))
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_4 << 1);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
			while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_10 < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8))
			{
				void* field_5 = ((void**)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_10];
				startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_5;
				startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_12 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5)
				{
					sbyte field_6 = (((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_12 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0) ? ((sbyte)1) : ((sbyte)0));
					startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_6;
					startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
					while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_14 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
					{
						bool num = (startFrame.GetLocalsPointer<LocalVariables>()->field_13 & 1) == 1 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_14 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_13 = (num ? ((sbyte)1) : ((sbyte)0));
						void* field_7 = Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_14 << 1);
						startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_7;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_12 & 1) != 0)
						{
							sbyte field_8 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_0;
							startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_8;
						}
						else
						{
							sbyte field_9 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_9;
							sbyte field_10 = (sbyte)(((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 & 3) | (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 >> 2) & 0xC));
							startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_10;
							short field_11 = (short)((((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 >> 2) & 3) | (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 >> 4) & 0xC));
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_0 = field_11;
						}
						if (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_16 & 3) == 0)
						{
							int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + num2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_12;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 - field_13;
								startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_14;
							}
							short field_15 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_1 = field_15;
						}
						else if (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_16 & 3) == 1)
						{
							short field_16 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_1 = field_16;
						}
						else if (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_16 & 3) == 3)
						{
							int field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_17;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_1 = (short)field_17;
						}
						else
						{
							int field_18 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_18;
						}
						sbyte field_19 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_16 >> 2);
						startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_19;
						int num3 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_7);
						*(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18) = num3;
						int field_20 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						startFrame.GetLocalsPointer<LocalVariables>()->field_20 = field_20;
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_16 != 0)
						{
							int num4 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							int field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + num4;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_21;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_22 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 - field_22;
								startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_23;
							}
						}
						int field_24 = (ushort)((crnd_crn_unpacker_block_buffer_element*)Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (startFrame.GetLocalsPointer<LocalVariables>()->field_14 << 1) | 1))->field_1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_24;
						short field_25 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
						((crnd_crn_unpacker_block_buffer_element*)Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (startFrame.GetLocalsPointer<LocalVariables>()->field_14 << 1) | 1))->field_1 = field_25;
						int num5 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_7);
						*(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_19) = num5;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_13 & 1) == 1)
						{
							int field_26 = ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_16 >> 1) ^ 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_21 = field_26;
							startFrame.GetLocalsPointer<LocalVariables>()->field_22 = 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_23 = 0;
							int field_27;
							int field_28;
							for (; startFrame.GetLocalsPointer<LocalVariables>()->field_22 != 0 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_23 < 3u; startFrame.GetLocalsPointer<LocalVariables>()->field_22 = field_27, field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_23 + 1, startFrame.GetLocalsPointer<LocalVariables>()->field_23 = field_28)
							{
								long num6 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_23;
								int num7;
								checked
								{
									num7 = unchecked((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18))[num6]) + 3;
								}
								long num8 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_23;
								if (num7 >= (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_19))[num8])
								{
									long num9 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_23;
									int num10;
									checked
									{
										num10 = unchecked((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_19))[num9]) + 4;
									}
									long num11 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_23;
									if (num10 >= (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18))[num11])
									{
										field_27 = startFrame.GetLocalsPointer<LocalVariables>()->field_22;
										continue;
									}
								}
								field_27 = 0;
							}
							startFrame.GetLocalsPointer<LocalVariables>()->field_24 = 0;
							while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24 < 3u)
							{
								int num17;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_22 != 0)
								{
									long num12 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24;
									int num13 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18))[num12] << 3;
									long num14 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24;
									byte num15 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_19))[num14];
									long num16 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24;
									checked
									{
										num17 = num13 | ((num15 - unchecked((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18))[num16])) & 7);
									}
								}
								else
								{
									long num18 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24;
									int num19 = ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18))[num18] << 3) & 0xF0;
									long num20 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24;
									num17 = num19 | ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_19))[num20] >> 1);
								}
								sbyte b = (sbyte)num17;
								long num21 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_24;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_17))[num21] = b;
								int field_29 = startFrame.GetLocalsPointer<LocalVariables>()->field_24 + 1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_24 = field_29;
							}
							sbyte b2 = (sbyte)(((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_18))[3] << 5) | ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_19))[3] << 2) | (startFrame.GetLocalsPointer<LocalVariables>()->field_22 << 1) | startFrame.GetLocalsPointer<LocalVariables>()->field_21);
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_17))[3] = b2;
							int num22 = *(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_17);
							*(int*)startFrame.GetLocalsPointer<LocalVariables>()->field_11 = num22;
							int num23 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, (startFrame.GetLocalsPointer<LocalVariables>()->field_20 << 1) | startFrame.GetLocalsPointer<LocalVariables>()->field_21);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[1] = num23;
						}
						int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_14 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_30;
						void* field_31 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11 + 8;
						startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_31;
					}
					int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_12 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_32;
					int field_33 = startFrame.GetLocalsPointer<LocalVariables>()->field_6;
					void* field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_11;
					startFrame.GetLocalsPointer<LocalVariables>()->field_11 = (byte*)field_34 + (nint)field_33 * (nint)4;
				}
				int field_35 = startFrame.GetLocalsPointer<LocalVariables>()->field_10 + 1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_35;
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
