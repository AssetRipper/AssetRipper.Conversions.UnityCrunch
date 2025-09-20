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
		public InlineArray16_Int32 field_0;

		public InlineArray17_Int32 field_1;

		public InlineArray17_Int32 field_2;
	}

	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int num_syms, [NativeType("unsigned char const *")] void* pCodesizes, [NativeType("unsigned int")] int table_bits)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		LocalVariables* localsPointer = startFrame.GetLocalsPointer<LocalVariables>();
		bool flag = false;
		localsPointer->field_0 = default(InlineArray16_Int32);
		localsPointer->field_1 = default(InlineArray17_Int32);
		int num = 0;
		int num2 = 0;
		localsPointer->field_2 = default(InlineArray17_Int32);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		int num14 = 0;
		int num15 = 0;
		int num16 = 0;
		int num17 = 0;
		int num18 = 0;
		int num19 = 0;
		int num20 = 0;
		int num21 = 0;
		int num22 = 0;
		int num23 = 0;
		int num24 = 0;
		int num25 = 0;
		int num26 = table_bits;
		unchecked
		{
			if (num_syms == 0 || (uint)num26 > 11u)
			{
				flag = false;
			}
			else
			{
				((crnd_prefix_coding_decoder_tables*)@this)->field_0 = num_syms;
				zero_object.Invoke(&localsPointer->field_1);
				for (num = 0; (uint)num < (uint)num_syms; num++)
				{
					num2 = (byte)((sbyte*)pCodesizes)[(uint)num];
					if (num2 != 0)
					{
						((int*)(&localsPointer->field_1))[(uint)num2]++;
					}
				}
				num3 = 0;
				num4 = 0;
				num5 = 0;
				num6 = -1;
				for (num7 = 1; (uint)num7 <= 16u; num7++)
				{
					num8 = ((int*)(&localsPointer->field_1))[(uint)num7];
					if (num8 == 0)
					{
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num7 - 1)] = 0;
					}
					else
					{
						num6 = minimum.Invoke(num6, num7);
						num5 = maximum.Invoke(num5, num7);
						((int*)(&localsPointer->field_0))[(uint)(num7 - 1)] = num3;
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num7 - 1)] = num3 + num8 - 1;
						int num27 = (((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num7 - 1)] << 16 - num7) | checked((1 << unchecked(16 - num7)) - 1);
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num7 - 1)] = 1 + num27;
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)(num7 - 1)] = num4;
						((int*)(&localsPointer->field_2))[(uint)num7] = num4;
						num3 += num8;
						num4 += num8;
					}
					num3 <<= 1;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_1 = num4;
				if ((uint)num4 > (uint)((crnd_prefix_coding_decoder_tables*)@this)->field_12)
				{
					((crnd_prefix_coding_decoder_tables*)@this)->field_12 = num4;
					if (!is_power_of_2.Invoke(num4))
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_12 = minimum.Invoke(num_syms, next_pow2.Invoke(num4));
					}
					if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 != null)
					{
						crnd_delete_array_rytswyc.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_13);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
					}
					void* field_ = crnd_new_array_ovofsdb.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_12);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					((crnd_prefix_coding_decoder_tables*)@this)->field_13 = field_;
					if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 == null)
					{
						flag = false;
						goto IL_080c;
					}
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_6 = (sbyte)num6;
				((crnd_prefix_coding_decoder_tables*)@this)->field_7 = (sbyte)num5;
				for (num9 = 0; (uint)num9 < (uint)num_syms; num9++)
				{
					num10 = (byte)((sbyte*)pCodesizes)[(uint)num9];
					if (num10 != 0)
					{
						int num28;
						if (((int*)(&localsPointer->field_1))[(uint)num10] != 0)
						{
							num28 = -1;
						}
						else
						{
							crnd_assert.Invoke(String_prifl7a.__pointer, String_yguirrd.__pointer, 1796);
							num28 = 0;
						}
						num11 = ((int*)(&localsPointer->field_2))[(uint)num10]++;
						int num29;
						if ((uint)num11 < (uint)num4)
						{
							num29 = -1;
						}
						else
						{
							crnd_assert.Invoke(String_ws3o7xb.__pointer, String_yguirrd.__pointer, 1800);
							num29 = 0;
						}
						((short*)((crnd_prefix_coding_decoder_tables*)@this)->field_13)[(uint)num11] = (short)num9;
					}
				}
				if ((uint)num26 <= (uint)(byte)((crnd_prefix_coding_decoder_tables*)@this)->field_6)
				{
					num26 = 0;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_2 = num26;
				if (num26 != 0)
				{
					num12 = 1 << num26;
					if ((uint)num12 > (uint)((crnd_prefix_coding_decoder_tables*)@this)->field_10)
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_10 = num12;
						if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 != null)
						{
							crnd_delete_array_nughn5d.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						void* field_2 = crnd_new_array_linsntd.Invoke(num12);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						((crnd_prefix_coding_decoder_tables*)@this)->field_11 = field_2;
						if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 == null)
						{
							flag = false;
							goto IL_080c;
						}
					}
					llvm_memset_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11, -1, (uint)(4 * (1 << num26)), isVolatile: false);
					for (num13 = 1; (uint)num13 <= (uint)num26; num13++)
					{
						if (((int*)(&localsPointer->field_1))[(uint)num13] == 0)
						{
							continue;
						}
						num14 = num26 - num13;
						num15 = 1 << num14;
						num16 = ((int*)(&localsPointer->field_0))[(uint)(num13 - 1)];
						num17 = Get_unshifted_max_code.Invoke(@this, num13);
						num18 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)(num13 - 1)];
						for (num19 = num16; (uint)num19 <= (uint)num17; num19++)
						{
							num20 = (ushort)((short*)((crnd_prefix_coding_decoder_tables*)@this)->field_13)[(uint)(num18 + num19 - num16)];
							int num30;
							if ((byte)((sbyte*)pCodesizes)[(uint)num20] == num13)
							{
								num30 = -1;
							}
							else
							{
								crnd_assert.Invoke(String_jvgs2qb.__pointer, String_yguirrd.__pointer, 1838);
								num30 = 0;
							}
							for (num21 = 0; (uint)num21 < (uint)num15; num21++)
							{
								num22 = num21 + (num19 << num14);
								int num31;
								if ((uint)num22 < (uint)(1 << num26))
								{
									num31 = -1;
								}
								else
								{
									crnd_assert.Invoke(String_yfa7b2a.__pointer, String_yguirrd.__pointer, 1843);
									num31 = 0;
								}
								int num32;
								if (((int*)((crnd_prefix_coding_decoder_tables*)@this)->field_11)[(uint)num22] == -1)
								{
									num32 = -1;
								}
								else
								{
									crnd_assert.Invoke(String_h5wt4bd.__pointer, String_yguirrd.__pointer, 1845);
									num32 = 0;
								}
								((int*)((crnd_prefix_coding_decoder_tables*)@this)->field_11)[(uint)num22] = num20 | (num13 << 16);
							}
						}
					}
				}
				for (num23 = 0; (uint)num23 < 16u; num23++)
				{
					int num33 = ((int*)(&localsPointer->field_0))[(uint)num23];
					((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)num23] -= num33;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_4 = 0;
				((crnd_prefix_coding_decoder_tables*)@this)->field_5 = (byte)((crnd_prefix_coding_decoder_tables*)@this)->field_6;
				if (num26 != 0)
				{
					for (num24 = num26; (uint)num24 >= 1u; num24 += -1)
					{
						if (((int*)(&localsPointer->field_1))[(uint)num24] != 0)
						{
							((crnd_prefix_coding_decoder_tables*)@this)->field_4 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num24 - 1)];
							break;
						}
					}
					if ((uint)num24 >= 1u)
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_5 = num26 + 1;
						for (num25 = num26 + 1; (uint)num25 <= (uint)num5; num25++)
						{
							if (((int*)(&localsPointer->field_1))[(uint)num25] != 0)
							{
								((crnd_prefix_coding_decoder_tables*)@this)->field_5 = num25;
								break;
							}
						}
					}
				}
				((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[16] = -1;
				((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[16] = 1048575;
				((crnd_prefix_coding_decoder_tables*)@this)->field_3 = 32 - ((crnd_prefix_coding_decoder_tables*)@this)->field_2;
				flag = true;
			}
			goto IL_080c;
		}
		IL_080c:
		bool result = flag;
		StackFrameList.Current.Clear(startFrame);
		return result;
	}
}
