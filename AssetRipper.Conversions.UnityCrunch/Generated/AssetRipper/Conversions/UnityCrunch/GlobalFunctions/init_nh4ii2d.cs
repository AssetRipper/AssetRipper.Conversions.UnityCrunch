using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init@static_huffman_data_model@crnd@@QEAA_NIPEBEI@Z")]
[DemangledName("public: bool __cdecl crnd::static_huffman_data_model::init(unsigned int, unsigned char const *, unsigned int)")]
[CleanName("init")]
internal static partial class init_nh4ii2d
{
	private partial struct LocalVariables
	{
		public bool field_0;

		public int field_1;

		public unsafe void* field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int field_6;

		public int field_7;
	}

	public unsafe static bool Invoke(void* @this, int total_syms, void* pCode_sizes, int code_size_limit)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_4 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_7 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = code_size_limit;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pCode_sizes;
		startFrame.GetLocalsPointer<LocalVariables>()->field_3 = total_syms;
		unchecked
		{
			int num;
			if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 >= 1u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3 <= 8192u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1 >= 1u)
			{
				num = -1;
			}
			else
			{
				crnd_assert.Invoke(String_ejppfib.__pointer, String_yguirrd.__pointer, 2433);
				num = 0;
			}
			int field_ = minimum.Invoke(startFrame.GetLocalsPointer<LocalVariables>()->field_1, 16);
			startFrame.GetLocalsPointer<LocalVariables>()->field_1 = field_;
			bool flag = resize_rzzl5xd.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, startFrame.GetLocalsPointer<LocalVariables>()->field_3);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
			}
			else
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_4 = -1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_5 = 0;
				startFrame.GetLocalsPointer<LocalVariables>()->field_6 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
				{
					int field_2 = (byte)((sbyte*)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6];
					startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_2;
					sbyte b = (sbyte)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
					*(sbyte*)Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, startFrame.GetLocalsPointer<LocalVariables>()->field_6) = b;
					int field_3 = minimum.Invoke(b: startFrame.GetLocalsPointer<LocalVariables>()->field_7, a: startFrame.GetLocalsPointer<LocalVariables>()->field_4);
					startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_3;
					int field_4 = maximum.Invoke(b: startFrame.GetLocalsPointer<LocalVariables>()->field_7, a: startFrame.GetLocalsPointer<LocalVariables>()->field_5);
					startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_4;
					int field_5 = startFrame.GetLocalsPointer<LocalVariables>()->field_6 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_5;
				}
				if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 < 1u || (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 > 32u || (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4 > (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5 > (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1)
				{
					startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
				}
				else
				{
					if (((crnd_static_huffman_data_model*)@this)->field_2 == null)
					{
						void* field_6 = crnd_new_9bg4xgd.Invoke();
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						((crnd_static_huffman_data_model*)@this)->field_2 = field_6;
					}
					bool flag2 = init_igqra9d.Invoke(((crnd_static_huffman_data_model*)@this)->field_2, table_bits: compute_decoder_table_bits.Invoke(@this), pCodesizes: Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, 0), num_syms: ((crnd_static_huffman_data_model*)@this)->field_0);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag2)
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = false;
					}
					else
					{
						startFrame.GetLocalsPointer<LocalVariables>()->field_0 = true;
					}
				}
			}
			bool field_7 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_7;
		}
	}
}
