using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_dxt5@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt5(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt5
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

		public sbyte field_10;

		public int field_11;

		public unsafe void* field_12;

		public int field_13;

		public sbyte field_14;

		public int field_15;

		public unsafe void* field_16;

		public sbyte field_17;

		public int field_18;

		public int field_19;

		public unsafe void* field_20;
	}

	public unsafe static bool Invoke(void* @this, void* pDst, int row_pitch_in_bytes, int output_width, int output_height)
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_17 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_18 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_19 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_20 = null;
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
			int field_5 = (row_pitch_in_bytes >>> 2) - (startFrame.GetLocalsPointer<LocalVariables>()->field_5 << 2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_5;
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5)
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
			}
			startFrame.GetLocalsPointer<LocalVariables>()->field_8 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_9 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_10 = 0;
			startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
			while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_11 < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8))
			{
				void* field_6 = ((void**)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_11];
				startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_6;
				startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_6)
				{
					sbyte field_7 = (((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0) ? ((sbyte)1) : ((sbyte)0));
					startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_7;
					startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
					while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_15 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5)
					{
						bool num = (startFrame.GetLocalsPointer<LocalVariables>()->field_14 & 1) == 1 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_15 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_14 = (num ? ((sbyte)1) : ((sbyte)0));
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_13 & 1) == 0 && (startFrame.GetLocalsPointer<LocalVariables>()->field_15 & 1) == 0)
						{
							sbyte field_8 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_8;
						}
						void* field_9 = Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_15);
						startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_9;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_13 & 1) != 0)
						{
							sbyte field_10 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_0;
							startFrame.GetLocalsPointer<LocalVariables>()->field_17 = field_10;
						}
						else
						{
							sbyte field_11 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_10 & 3);
							startFrame.GetLocalsPointer<LocalVariables>()->field_17 = field_11;
							sbyte field_12 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_10 >> 2);
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_12;
							short field_13 = (short)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_10 & 3);
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_0 = field_13;
							sbyte field_14 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_10 >> 2);
							startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_14;
						}
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_17 == 0)
						{
							int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							int field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + num2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_15;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_17 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 - field_16;
								startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_17;
							}
							short field_18 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_1 = field_18;
							int num3 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							int field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 + num3;
							startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_19;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
							{
								int field_20 = startFrame.GetLocalsPointer<LocalVariables>()->field_4;
								int field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 - field_20;
								startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_21;
							}
							short field_22 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_9;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_2 = field_22;
						}
						else if ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_17 == 1)
						{
							short field_23 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_1 = field_23;
							short field_24 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_9;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_2 = field_24;
						}
						else
						{
							int field_25 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_25;
							int field_26 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_16)->field_2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_26;
						}
						int field_27 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						startFrame.GetLocalsPointer<LocalVariables>()->field_18 = field_27;
						int field_28 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						startFrame.GetLocalsPointer<LocalVariables>()->field_19 = field_28;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_14 & 1) == 1)
						{
							void* field_29 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, startFrame.GetLocalsPointer<LocalVariables>()->field_19 * 3);
							startFrame.GetLocalsPointer<LocalVariables>()->field_20 = field_29;
							int num4 = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_10, startFrame.GetLocalsPointer<LocalVariables>()->field_9)) | ((ushort)(*(short*)startFrame.GetLocalsPointer<LocalVariables>()->field_20) << 16);
							*(int*)startFrame.GetLocalsPointer<LocalVariables>()->field_12 = num4;
							int num5 = (ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_20)[1] | ((ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_20)[2] << 16);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_12)[1] = num5;
							int num6 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_8);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_12)[2] = num6;
							int num7 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, startFrame.GetLocalsPointer<LocalVariables>()->field_18);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_12)[3] = num7;
						}
						int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_15 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_30;
						void* field_31 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_12 + 16;
						startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_31;
					}
					int field_32 = startFrame.GetLocalsPointer<LocalVariables>()->field_13 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_32;
					int field_33 = startFrame.GetLocalsPointer<LocalVariables>()->field_7;
					void* field_34 = startFrame.GetLocalsPointer<LocalVariables>()->field_12;
					startFrame.GetLocalsPointer<LocalVariables>()->field_12 = (byte*)field_34 + (nint)field_33 * (nint)4;
				}
				int field_35 = startFrame.GetLocalsPointer<LocalVariables>()->field_11 + 1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_35;
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
