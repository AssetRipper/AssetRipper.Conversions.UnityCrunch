using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init@decoder_tables@prefix_coding@crnd@@QEAA_NIPEBEI@Z")]
[DemangledName("public: bool __cdecl crnd::prefix_coding::decoder_tables::init(unsigned int, unsigned char const *, unsigned int)")]
[CleanName("init")]
internal static partial class init_igqra9d
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public unsafe void* field_2;

		public int field_3;

		public InlineArray_16_vqkfj7a field_4;

		public InlineArray_17_vqkfj7a field_5;

		public int field_6;

		public int field_7;

		public InlineArray_17_vqkfj7a field_8;

		public int field_9;

		public int field_10;

		public int field_11;

		public int field_12;

		public int field_13;

		public int field_14;

		public int field_15;

		public int field_16;

		public int field_17;

		public int field_18;

		public int field_19;

		public int field_20;

		public int field_21;

		public int field_22;

		public int field_23;

		public int field_24;

		public int field_25;

		public int field_26;

		public int field_27;

		public int field_28;

		public int field_29;

		public int field_30;

		public int field_31;
	}

	public unsafe static bool Invoke(void* @this, int num_syms, void* pCodesizes, int table_bits)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = default(InlineArray_16_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = default(InlineArray_17_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_8 = default(InlineArray_17_vqkfj7a);
		startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_17 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_18 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_19 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_20 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_21 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_22 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_23 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_24 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_25 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_26 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_27 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_28 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_29 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_30 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_31 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = table_bits;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pCodesizes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = num_syms;
		unchecked
		{
			if (startFrame.GetLocalsPointer<LocalVariables>()->field_3 == 0 || (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 > 11u)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				((crnd_prefix_coding_decoder_tables*)@this)->field_0 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
				zero_object.Invoke(&startFrame.GetLocalsPointer<LocalVariables>()->field_5);
				startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
				{
					int field_ = (byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6];
					startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_;
					if (startFrame.GetLocalsPointer<LocalVariables>()->field_7 != 0)
					{
						long num = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num]++;
					}
					int field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_2;
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
				startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
				startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
				startFrame.GetLocalsPointer<LocalVariables>()->field_12 = -1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 1;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 <= 16u)
				{
					long num2 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13;
					int field_3 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num2];
					startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_3;
					if (startFrame.GetLocalsPointer<LocalVariables>()->field_14 == 0)
					{
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 - 1)] = 0;
					}
					else
					{
						int field_4 = minimum.Invoke(b: startFrame.GetLocalsPointer<LocalVariables>()->field_13, a: startFrame.GetLocalsPointer<LocalVariables>()->field_12);
						startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_4;
						int field_5 = maximum.Invoke(b: startFrame.GetLocalsPointer<LocalVariables>()->field_13, a: startFrame.GetLocalsPointer<LocalVariables>()->field_11);
						startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_5;
						int field_6 = startFrame.GetLocalsPointer<LocalVariables>()->field_9;
						long num3 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 - 1);
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[num3] = field_6;
						int num4 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 + startFrame.GetLocalsPointer<LocalVariables>()->field_14 - 1;
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 - 1)] = num4;
						int num5 = (((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 - 1)] << 16 - startFrame.GetLocalsPointer<LocalVariables>()->field_13) | checked((1 << unchecked(16 - startFrame.GetLocalsPointer<LocalVariables>()->field_13)) - 1);
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 - 1)] = 1 + num5;
						int field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_13 - 1)] = field_7;
						int field_8 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
						long num6 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13;
						((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_8))[num6] = field_8;
						int field_9 = startFrame.GetLocalsPointer<LocalVariables>()->field_14;
						int field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 + field_9;
						startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_10;
						int field_11 = startFrame.GetLocalsPointer<LocalVariables>()->field_14;
						int field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_10 + field_11;
						startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_12;
					}
					int field_13 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 << 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_13;
					int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_13 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_14;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_1 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
				if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_10 > (uint)((crnd_prefix_coding_decoder_tables*)@this)->field_12)
				{
					((crnd_prefix_coding_decoder_tables*)@this)->field_12 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
					if (!is_power_of_2.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_10))
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_12 = minimum.Invoke(b: next_pow2.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_10), a: startFrame.GetLocalsPointer<LocalVariables>()->field_3);
					}
					if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 != null)
					{
						crnd_delete_array_rytswyc.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_13);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					void* field_15 = crnd_new_array_ovofsdb.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_12);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((crnd_prefix_coding_decoder_tables*)@this)->field_13 = field_15;
					if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 == null)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
						goto IL_10b4;
					}
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_6 = (sbyte)startFrame.GetLocalsPointer<LocalVariables>()->field_12;
				((crnd_prefix_coding_decoder_tables*)@this)->field_7 = (sbyte)startFrame.GetLocalsPointer<LocalVariables>()->field_11;
				startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_15 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
				{
					int field_16 = (byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_15];
					startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_16;
					if (startFrame.GetLocalsPointer<LocalVariables>()->field_16 != 0)
					{
						long num7 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_16;
						int num8;
						if (((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num7] != 0)
						{
							num8 = -1;
						}
						else
						{
							crnd_assert.Invoke(String_prifl7a.__pointer, String_yguirrd.__pointer, 1796);
							num8 = 0;
						}
						long num9 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_16;
						int field_17 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_8))[num9]++;
						startFrame.GetLocalsPointer<LocalVariables>()->field_17 = field_17;
						int num10;
						if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_17 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_10)
						{
							num10 = -1;
						}
						else
						{
							crnd_assert.Invoke(String_ws3o7xb.__pointer, String_yguirrd.__pointer, 1800);
							num10 = 0;
						}
						short num11 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_15;
						((short*)((crnd_prefix_coding_decoder_tables*)@this)->field_13)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_17] = num11;
					}
					int field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_15 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_18;
				}
				if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 <= (uint)(byte)((crnd_prefix_coding_decoder_tables*)@this)->field_6)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_2 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 != 0)
				{
					int field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_18 = 1 << field_19;
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_18 > (uint)((crnd_prefix_coding_decoder_tables*)@this)->field_10)
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_10 = startFrame.GetLocalsPointer<LocalVariables>()->field_18;
						if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 != null)
						{
							crnd_delete_array_nughn5d.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						void* field_20 = crnd_new_array_linsntd.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_18);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						((crnd_prefix_coding_decoder_tables*)@this)->field_11 = field_20;
						if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 == null)
						{
							startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
							goto IL_10b4;
						}
					}
					llvm_memset_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11, -1, (uint)(4 * (1 << startFrame.GetLocalsPointer<LocalVariables>()->field_1)), isVolatile: false);
					startFrame.GetLocalsPointer<LocalVariables>()->field_19 = 1;
					while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_19 <= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1)
					{
						long num12 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_19;
						if (((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num12] != 0)
						{
							int field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 - startFrame.GetLocalsPointer<LocalVariables>()->field_19;
							startFrame.GetLocalsPointer<LocalVariables>()->field_20 = field_21;
							int field_22 = startFrame.GetLocalsPointer<LocalVariables>()->field_20;
							startFrame.GetLocalsPointer<LocalVariables>()->field_21 = 1 << field_22;
							long num13 = (uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_19 - 1);
							int field_23 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[num13];
							startFrame.GetLocalsPointer<LocalVariables>()->field_22 = field_23;
							int field_24 = Get_unshifted_max_code.Invoke(@this, startFrame.GetLocalsPointer<LocalVariables>()->field_19);
							startFrame.GetLocalsPointer<LocalVariables>()->field_23 = field_24;
							int field_25 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_19 - 1)];
							startFrame.GetLocalsPointer<LocalVariables>()->field_24 = field_25;
							int field_26 = startFrame.GetLocalsPointer<LocalVariables>()->field_22;
							startFrame.GetLocalsPointer<LocalVariables>()->field_25 = field_26;
							while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_25 <= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_23)
							{
								int field_27 = (ushort)((short*)((crnd_prefix_coding_decoder_tables*)@this)->field_13)[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_24 + startFrame.GetLocalsPointer<LocalVariables>()->field_25 - startFrame.GetLocalsPointer<LocalVariables>()->field_22)];
								startFrame.GetLocalsPointer<LocalVariables>()->field_26 = field_27;
								int num14;
								if ((byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_26] == startFrame.GetLocalsPointer<LocalVariables>()->field_19)
								{
									num14 = -1;
								}
								else
								{
									crnd_assert.Invoke(String_jvgs2qb.__pointer, String_yguirrd.__pointer, 1838);
									num14 = 0;
								}
								startFrame.GetLocalsPointer<LocalVariables>()->field_27 = 0;
								while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_27 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_21)
								{
									int field_28 = startFrame.GetLocalsPointer<LocalVariables>()->field_27 + (startFrame.GetLocalsPointer<LocalVariables>()->field_25 << startFrame.GetLocalsPointer<LocalVariables>()->field_20);
									startFrame.GetLocalsPointer<LocalVariables>()->field_28 = field_28;
									int num15;
									if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28 < (uint)(1 << startFrame.GetLocalsPointer<LocalVariables>()->field_1))
									{
										num15 = -1;
									}
									else
									{
										crnd_assert.Invoke(String_yfa7b2a.__pointer, String_yguirrd.__pointer, 1843);
										num15 = 0;
									}
									int num16;
									if (((int*)((crnd_prefix_coding_decoder_tables*)@this)->field_11)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28] == -1)
									{
										num16 = -1;
									}
									else
									{
										crnd_assert.Invoke(String_h5wt4bd.__pointer, String_yguirrd.__pointer, 1845);
										num16 = 0;
									}
									int num17 = startFrame.GetLocalsPointer<LocalVariables>()->field_26 | (startFrame.GetLocalsPointer<LocalVariables>()->field_19 << 16);
									((int*)((crnd_prefix_coding_decoder_tables*)@this)->field_11)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_28] = num17;
									int field_29 = startFrame.GetLocalsPointer<LocalVariables>()->field_27 + 1;
									startFrame.GetLocalsPointer<LocalVariables>()->field_27 = field_29;
								}
								int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_25 + 1;
								startFrame.GetLocalsPointer<LocalVariables>()->field_25 = field_30;
							}
						}
						int field_31 = startFrame.GetLocalsPointer<LocalVariables>()->field_19 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_19 = field_31;
					}
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_29 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_29 < 16u)
				{
					long num18 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_29;
					int num19 = ((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_4))[num18];
					((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_29] -= num19;
					int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_29 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_29 = field_32;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_4 = 0;
				((crnd_prefix_coding_decoder_tables*)@this)->field_5 = (byte)((crnd_prefix_coding_decoder_tables*)@this)->field_6;
				if (startFrame.GetLocalsPointer<LocalVariables>()->field_1 != 0)
				{
					int field_33 = startFrame.GetLocalsPointer<LocalVariables>()->field_1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_30 = field_33;
					while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_30 >= 1u)
					{
						long num20 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_30;
						if (((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num20] != 0)
						{
							((crnd_prefix_coding_decoder_tables*)@this)->field_4 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(startFrame.GetLocalsPointer<LocalVariables>()->field_30 - 1)];
							break;
						}
						int field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_30 + -1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_30 = field_34;
					}
					if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_30 >= 1u)
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + 1;
						int field_35 = startFrame.GetLocalsPointer<LocalVariables>()->field_1 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_31 = field_35;
						while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_31 <= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_11)
						{
							long num21 = (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_31;
							if (((int*)(&startFrame.GetLocalsPointer<LocalVariables>()->field_5))[num21] != 0)
							{
								((crnd_prefix_coding_decoder_tables*)@this)->field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_31;
								break;
							}
							int field_36 = startFrame.GetLocalsPointer<LocalVariables>()->field_31 + 1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_31 = field_36;
						}
					}
				}
				((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[16] = -1;
				((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[16] = 1048575;
				((crnd_prefix_coding_decoder_tables*)@this)->field_3 = 32 - ((crnd_prefix_coding_decoder_tables*)@this)->field_2;
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
			}
			goto IL_10b4;
		}
		IL_10b4:
		bool field_37 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
		StackFrameList.Current.Clear(startFrame);
		return field_37;
	}
}
