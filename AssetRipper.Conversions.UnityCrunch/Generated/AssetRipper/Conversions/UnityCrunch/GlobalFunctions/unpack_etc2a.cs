using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_etc2a@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_etc2a(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_etc2a
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

		public int field_9;

		public int field_10;

		public int field_11;

		public sbyte field_12;

		public int field_13;

		public unsafe void* field_14;

		public int field_15;

		public sbyte field_16;

		public int field_17;

		public unsafe void* field_18;

		public sbyte field_19;

		public InlineArray_4_w3otm9c field_20;

		public InlineArray_4_w3otm9c field_21;

		public InlineArray_4_w3otm9c field_22;

		public int field_23;

		public int field_24;

		public int field_25;

		public int field_26;

		public int field_27;

		public int field_28;

		public unsafe void* field_29;
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_17 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_18 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_19 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_20 = default(InlineArray_4_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_21 = default(InlineArray_4_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_22 = default(InlineArray_4_w3otm9c);
		startFrame.GetLocalsPointer<LocalVariables>()->field_23 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_24 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_25 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_26 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_27 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_28 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_29 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = output_height;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = output_width;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pDst;
		unchecked
		{
			int field_ = size_7uifdkc.Invoke(&((crnd_crn_unpacker*)@this)->field_8);
			startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_;
			int field_2 = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_2;
			int field_3 = (startFrame.GetLocalsPointer<LocalVariables>()->field_1 + 1) & -2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_3;
			int field_4 = (startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 1) & -2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_4;
			int field_5 = (output_pitch_in_bytes >>> 2) - (startFrame.GetLocalsPointer<LocalVariables>()->field_5 << 2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_5;
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_5 << 1))
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_5 << 1);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
			while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8))
			{
				void* field_6 = ((void**)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13];
				startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_6;
				startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_15 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6)
				{
					sbyte field_7 = (((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_15 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0) ? ((sbyte)1) : ((sbyte)0));
					startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_7;
					startFrame.GetLocalsPointer<LocalVariables>()->field_17 = 0;
					while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_17 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5)
					{
						bool num = (startFrame.GetLocalsPointer<LocalVariables>()->field_16 & 1) == 1 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_17 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_16 = (num ? ((sbyte)1) : ((sbyte)0));
						void* field_8 = Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_17 << 1);
						startFrame.GetLocalsPointer<LocalVariables>()->field_18 = field_8;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_15 & 1) != 0)
						{
							sbyte field_9 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_0;
							startFrame.GetLocalsPointer<LocalVariables>()->field_19 = field_9;
						}
						else
						{
							sbyte field_10 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_10;
							sbyte field_11 = (sbyte)(((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_12 & 3) | (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_12 >> 2) & 0xC));
							startFrame.GetLocalsPointer<LocalVariables>()->field_19 = field_11;
							short field_12 = (short)((((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_12 >> 2) & 3) | (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_12 >> 4) & 0xC));
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_0 = field_12;
						}
						if (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_19 & 3) == 0)
						{
							int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							int field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + num2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_13;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 - field_14;
								startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_15;
							}
							int num3 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_10 + num3;
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_16;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_10 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
							{
								int field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_4;
								int field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_10 - field_17;
								startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_18;
							}
							short field_19 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_1 = field_19;
							short field_20 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_10;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_2 = field_20;
						}
						else if (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_19 & 3) == 1)
						{
							short field_21 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_1 = field_21;
							short field_22 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_10;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_2 = field_22;
						}
						else if (((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_19 & 3) == 3)
						{
							int field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_9;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_23;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_1 = (short)field_23;
							int field_24 = startFrame.GetLocalsPointer<LocalVariables>()->field_11;
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_24;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_2 = (short)field_24;
						}
						else
						{
							int field_25 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_25;
							int field_26 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_18)->field_2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_26;
						}
						sbyte field_27 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_19 >> 2);
						startFrame.GetLocalsPointer<LocalVariables>()->field_19 = field_27;
						int num4 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_8);
						*(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21) = num4;
						int field_28 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						startFrame.GetLocalsPointer<LocalVariables>()->field_23 = field_28;
						int field_29 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						startFrame.GetLocalsPointer<LocalVariables>()->field_24 = field_29;
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_19 != 0)
						{
							int num5 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + num5;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_30;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_31 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 - field_31;
								startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_32;
							}
						}
						int num6 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_8);
						*(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_22) = num6;
						int field_33 = (ushort)((crnd_crn_unpacker_block_buffer_element*)Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (startFrame.GetLocalsPointer<LocalVariables>()->field_17 << 1) | 1))->field_1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_33;
						int field_34 = (ushort)((crnd_crn_unpacker_block_buffer_element*)Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (startFrame.GetLocalsPointer<LocalVariables>()->field_17 << 1) | 1))->field_2;
						startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_34;
						short field_35 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
						((crnd_crn_unpacker_block_buffer_element*)Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (startFrame.GetLocalsPointer<LocalVariables>()->field_17 << 1) | 1))->field_1 = field_35;
						short field_36 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_10;
						((crnd_crn_unpacker_block_buffer_element*)Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, (startFrame.GetLocalsPointer<LocalVariables>()->field_17 << 1) | 1))->field_2 = field_36;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_16 & 1) == 1)
						{
							int field_37 = ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_19 >> 1) ^ 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_25 = field_37;
							startFrame.GetLocalsPointer<LocalVariables>()->field_26 = 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_27 = 0;
							int field_38;
							int field_39;
							for (; startFrame.GetLocalsPointer<LocalVariables>()->field_26 != 0 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_27 < 3u; startFrame.GetLocalsPointer<LocalVariables>()->field_26 = field_38, field_39 = startFrame.GetLocalsPointer<LocalVariables>()->field_27 + 1, startFrame.GetLocalsPointer<LocalVariables>()->field_27 = field_39)
							{
								long num7 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_27;
								int num8;
								checked
								{
									num8 = unchecked((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21))[num7]) + 3;
								}
								long num9 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_27;
								if (num8 >= (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_22))[num9])
								{
									long num10 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_27;
									int num11;
									checked
									{
										num11 = unchecked((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_22))[num10]) + 4;
									}
									long num12 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_27;
									if (num11 >= (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21))[num12])
									{
										field_38 = startFrame.GetLocalsPointer<LocalVariables>()->field_26;
										continue;
									}
								}
								field_38 = 0;
							}
							startFrame.GetLocalsPointer<LocalVariables>()->field_28 = 0;
							while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28 < 3u)
							{
								int num18;
								if (startFrame.GetLocalsPointer<LocalVariables>()->field_26 != 0)
								{
									long num13 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28;
									int num14 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21))[num13] << 3;
									long num15 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28;
									byte num16 = (byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_22))[num15];
									long num17 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28;
									checked
									{
										num18 = num14 | ((num16 - unchecked((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21))[num17])) & 7);
									}
								}
								else
								{
									long num19 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28;
									int num20 = ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21))[num19] << 3) & 0xF0;
									long num21 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28;
									num18 = num20 | ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_22))[num21] >> 1);
								}
								sbyte b = (sbyte)num18;
								long num22 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28;
								((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_20))[num22] = b;
								int field_40 = startFrame.GetLocalsPointer<LocalVariables>()->field_28 + 1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_28 = field_40;
							}
							sbyte b2 = (sbyte)(((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_21))[3] << 5) | ((byte)((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_22))[3] << 2) | (startFrame.GetLocalsPointer<LocalVariables>()->field_26 << 1) | startFrame.GetLocalsPointer<LocalVariables>()->field_25);
							((sbyte*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_20))[3] = b2;
							crnd_vector_8* field_41 = &((crnd_crn_unpacker*)@this)->field_11;
							int num23 = startFrame.GetLocalsPointer<LocalVariables>()->field_24 * 6;
							bool flag = startFrame.GetLocalsPointer<LocalVariables>()->field_25 != 0;
							_ = flag;
							void* field_42 = Index_uimxdqb.Invoke(field_41, num23 + InstructionHelper.Select(flag, 3, 0));
							startFrame.GetLocalsPointer<LocalVariables>()->field_29 = field_42;
							int num24 = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_10, startFrame.GetLocalsPointer<LocalVariables>()->field_10)) | ((ushort)(*(short*)startFrame.GetLocalsPointer<LocalVariables>()->field_29) << 16);
							*(int*)startFrame.GetLocalsPointer<LocalVariables>()->field_14 = num24;
							int num25 = (ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_29)[1] | ((ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_29)[2] << 16);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)[1] = num25;
							int num26 = *(int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_20);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)[2] = num26;
							int num27 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, (startFrame.GetLocalsPointer<LocalVariables>()->field_23 << 1) | startFrame.GetLocalsPointer<LocalVariables>()->field_25);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)[3] = num27;
						}
						int field_43 = startFrame.GetLocalsPointer<LocalVariables>()->field_17 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_17 = field_43;
						void* field_44 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_14 + 16;
						startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_44;
					}
					int field_45 = startFrame.GetLocalsPointer<LocalVariables>()->field_15 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_45;
					int field_46 = startFrame.GetLocalsPointer<LocalVariables>()->field_7;
					void* field_47 = startFrame.GetLocalsPointer<LocalVariables>()->field_14;
					startFrame.GetLocalsPointer<LocalVariables>()->field_14 = (byte*)field_47 + (nint)field_46 * (nint)4;
				}
				int field_48 = startFrame.GetLocalsPointer<LocalVariables>()->field_13 + 1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_48;
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
