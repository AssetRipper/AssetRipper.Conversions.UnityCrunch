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
		localsPointer->field_0 = default(InlineArray16_Int32);
		localsPointer->field_1 = default(InlineArray17_Int32);
		localsPointer->field_2 = default(InlineArray17_Int32);
		int num = table_bits;
		bool flag;
		unchecked
		{
			if (num_syms == 0 || (uint)num > 11u)
			{
				flag = false;
			}
			else
			{
				((crnd_prefix_coding_decoder_tables*)@this)->field_0 = num_syms;
				zero_object.Invoke(&localsPointer->field_1);
				for (int i = 0; (uint)i < (uint)num_syms; i++)
				{
					int num2 = (byte)((sbyte*)pCodesizes)[(uint)i];
					if (num2 != 0)
					{
						((int*)(&localsPointer->field_1))[(uint)num2]++;
					}
				}
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = -1;
				for (int j = 1; (uint)j <= 16u; j++)
				{
					int num7 = ((int*)(&localsPointer->field_1))[(uint)j];
					if (num7 == 0)
					{
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(j - 1)] = 0;
					}
					else
					{
						num6 = minimum.Invoke(num6, j);
						num5 = maximum.Invoke(num5, j);
						((int*)(&localsPointer->field_0))[(uint)(j - 1)] = num3;
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(j - 1)] = num3 + num7 - 1;
						int num8 = (((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(j - 1)] << 16 - j) | checked((1 << unchecked(16 - j)) - 1);
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(j - 1)] = 1 + num8;
						((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)(j - 1)] = num4;
						((int*)(&localsPointer->field_2))[(uint)j] = num4;
						num3 += num7;
						num4 += num7;
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
				for (int k = 0; (uint)k < (uint)num_syms; k++)
				{
					int num9 = (byte)((sbyte*)pCodesizes)[(uint)k];
					if (num9 != 0)
					{
						if (((int*)(&localsPointer->field_1))[(uint)num9] == 0)
						{
							crnd_assert.Invoke(String_prifl7a.__pointer, String_yguirrd.__pointer, 1796);
						}
						int num10 = ((int*)(&localsPointer->field_2))[(uint)num9]++;
						if ((uint)num10 >= (uint)num4)
						{
							crnd_assert.Invoke(String_ws3o7xb.__pointer, String_yguirrd.__pointer, 1800);
						}
						((short*)((crnd_prefix_coding_decoder_tables*)@this)->field_13)[(uint)num10] = (short)k;
					}
				}
				if ((uint)num <= (uint)(byte)((crnd_prefix_coding_decoder_tables*)@this)->field_6)
				{
					num = 0;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_2 = num;
				if (num != 0)
				{
					int num11 = 1 << num;
					if ((uint)num11 > (uint)((crnd_prefix_coding_decoder_tables*)@this)->field_10)
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_10 = num11;
						if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 != null)
						{
							crnd_delete_array_nughn5d.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11);
							if (ExceptionInfo.Current != null)
							{
								return false;
							}
						}
						void* field_2 = crnd_new_array_linsntd.Invoke(num11);
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
					llvm_memset_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11, -1, (uint)(4 * (1 << num)), isVolatile: false);
					for (int l = 1; (uint)l <= (uint)num; l++)
					{
						if (((int*)(&localsPointer->field_1))[(uint)l] == 0)
						{
							continue;
						}
						int num12 = num - l;
						int num13 = 1 << num12;
						int num14 = ((int*)(&localsPointer->field_0))[(uint)(l - 1)];
						int num15 = Get_unshifted_max_code.Invoke(@this, l);
						int num16 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)(l - 1)];
						for (int m = num14; (uint)m <= (uint)num15; m++)
						{
							int num17 = (ushort)((short*)((crnd_prefix_coding_decoder_tables*)@this)->field_13)[(uint)(num16 + m - num14)];
							if ((byte)((sbyte*)pCodesizes)[(uint)num17] != l)
							{
								crnd_assert.Invoke(String_jvgs2qb.__pointer, String_yguirrd.__pointer, 1838);
							}
							for (int n = 0; (uint)n < (uint)num13; n++)
							{
								int num18 = n + (m << num12);
								if ((uint)num18 >= (uint)(1 << num))
								{
									crnd_assert.Invoke(String_yfa7b2a.__pointer, String_yguirrd.__pointer, 1843);
								}
								if (((int*)((crnd_prefix_coding_decoder_tables*)@this)->field_11)[(uint)num18] != -1)
								{
									crnd_assert.Invoke(String_h5wt4bd.__pointer, String_yguirrd.__pointer, 1845);
								}
								((int*)((crnd_prefix_coding_decoder_tables*)@this)->field_11)[(uint)num18] = num17 | (l << 16);
							}
						}
					}
				}
				for (int num19 = 0; (uint)num19 < 16u; num19++)
				{
					int num20 = ((int*)(&localsPointer->field_0))[(uint)num19];
					((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_9))[(uint)num19] -= num20;
				}
				((crnd_prefix_coding_decoder_tables*)@this)->field_4 = 0;
				((crnd_prefix_coding_decoder_tables*)@this)->field_5 = (byte)((crnd_prefix_coding_decoder_tables*)@this)->field_6;
				if (num != 0)
				{
					int num21;
					for (num21 = num; (uint)num21 >= 1u; num21 += -1)
					{
						if (((int*)(&localsPointer->field_1))[(uint)num21] != 0)
						{
							((crnd_prefix_coding_decoder_tables*)@this)->field_4 = ((int*)(&((crnd_prefix_coding_decoder_tables*)@this)->field_8))[(uint)(num21 - 1)];
							break;
						}
					}
					if ((uint)num21 >= 1u)
					{
						((crnd_prefix_coding_decoder_tables*)@this)->field_5 = num + 1;
						for (int num22 = num + 1; (uint)num22 <= (uint)num5; num22++)
						{
							if (((int*)(&localsPointer->field_1))[(uint)num22] != 0)
							{
								((crnd_prefix_coding_decoder_tables*)@this)->field_5 = num22;
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
