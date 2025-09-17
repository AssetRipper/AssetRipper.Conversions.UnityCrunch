using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_dxn@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxn(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxn
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

		public int field_17;

		public int field_18;

		public unsafe void* field_19;

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
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_17 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_18 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_19 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_20 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = output_height;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = output_width;
		startFrame.GetLocalsPointer<LocalVariables>()->field_2 = pDst;
		unchecked
		{
			int field_ = size_lxodu4b.Invoke(&((crnd_crn_unpacker*)@this)->field_10);
			startFrame.GetLocalsPointer<LocalVariables>()->field_3 = field_;
			int field_2 = (startFrame.GetLocalsPointer<LocalVariables>()->field_1 + 1) & -2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_4 = field_2;
			int field_3 = (startFrame.GetLocalsPointer<LocalVariables>()->field_0 + 1) & -2;
			startFrame.GetLocalsPointer<LocalVariables>()->field_5 = field_3;
			int field_4 = (row_pitch_in_bytes >>> 2) - (startFrame.GetLocalsPointer<LocalVariables>()->field_4 << 2);
			startFrame.GetLocalsPointer<LocalVariables>()->field_6 = field_4;
			if ((uint)size_jm5h2sb.Invoke(&((crnd_crn_unpacker*)@this)->field_12) < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
			{
				resize_kfwzjla.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_4);
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
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_12 & 1) == 0 && (startFrame.GetLocalsPointer<LocalVariables>()->field_14 & 1) == 0)
						{
							sbyte field_7 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_7;
						}
						void* field_8 = Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_14);
						startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_8;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_12 & 1) != 0)
						{
							sbyte field_9 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_0;
							startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_9;
						}
						else
						{
							sbyte field_10 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 & 3);
							startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_10;
							sbyte field_11 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 >> 2);
							startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_11;
							short field_12 = (short)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 & 3);
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_0 = field_12;
							sbyte field_13 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_9 >> 2);
							startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_13;
						}
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_16 == 0)
						{
							int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + num2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_14;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 - field_15;
								startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_16;
							}
							short field_17 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_2 = field_17;
							int num3 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
							int field_18 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 + num3;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_18;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_8 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_19 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_20 = startFrame.GetLocalsPointer<LocalVariables>()->field_8 - field_19;
								startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_20;
							}
							short field_21 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_3 = field_21;
						}
						else if ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_16 == 1)
						{
							short field_22 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_2 = field_22;
							short field_23 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_8;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_3 = field_23;
						}
						else
						{
							int field_24 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_24;
							int field_25 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_15)->field_3;
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_25;
						}
						int field_26 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						startFrame.GetLocalsPointer<LocalVariables>()->field_17 = field_26;
						int field_27 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
						startFrame.GetLocalsPointer<LocalVariables>()->field_18 = field_27;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_13 & 1) == 1)
						{
							void* field_28 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, startFrame.GetLocalsPointer<LocalVariables>()->field_17 * 3);
							startFrame.GetLocalsPointer<LocalVariables>()->field_19 = field_28;
							void* field_29 = Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_11, startFrame.GetLocalsPointer<LocalVariables>()->field_18 * 3);
							startFrame.GetLocalsPointer<LocalVariables>()->field_20 = field_29;
							int num4 = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_10, startFrame.GetLocalsPointer<LocalVariables>()->field_7)) | ((ushort)(*(short*)startFrame.GetLocalsPointer<LocalVariables>()->field_19) << 16);
							*(int*)startFrame.GetLocalsPointer<LocalVariables>()->field_11 = num4;
							int num5 = (ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_19)[1] | ((ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_19)[2] << 16);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[1] = num5;
							int num6 = (ushort)(*(short*)Index_uimxdqb.Invoke(&((crnd_crn_unpacker*)@this)->field_10, startFrame.GetLocalsPointer<LocalVariables>()->field_8)) | ((ushort)(*(short*)startFrame.GetLocalsPointer<LocalVariables>()->field_20) << 16);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[2] = num6;
							int num7 = (ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_20)[1] | ((ushort)((short*)startFrame.GetLocalsPointer<LocalVariables>()->field_20)[2] << 16);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_11)[3] = num7;
						}
						int field_30 = startFrame.GetLocalsPointer<LocalVariables>()->field_14 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_30;
						void* field_31 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_11 + 16;
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
