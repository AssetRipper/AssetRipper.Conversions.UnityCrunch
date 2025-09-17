using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_dxt1@crn_unpacker@crnd@@AEAA_NPEAPEAEIII@Z")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::unpack_dxt1(unsigned char **, unsigned int, unsigned int, unsigned int)")]
internal static partial class unpack_dxt1
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

		public sbyte field_8;

		public int field_9;

		public unsafe void* field_10;

		public int field_11;

		public sbyte field_12;

		public int field_13;

		public unsafe void* field_14;

		public sbyte field_15;

		public int field_16;
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
		startFrame.GetLocalsPointer<LocalVariables>()->field_10 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_12 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_14 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_15 = 0;
		startFrame.GetLocalsPointer<LocalVariables>()->field_16 = 0;
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
			while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9 < (uint)operator_unsigned_int_neugqod.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_8))
			{
				void* field_5 = ((void**)startFrame.GetLocalsPointer<LocalVariables>()->field_2)[(uint)startFrame.GetLocalsPointer<LocalVariables>()->field_9];
				startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_5;
				startFrame.GetLocalsPointer<LocalVariables>()->field_11 = 0;
				while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_11 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_5)
				{
					sbyte field_6 = (((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_11 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0) ? ((sbyte)1) : ((sbyte)0));
					startFrame.GetLocalsPointer<LocalVariables>()->field_12 = field_6;
					startFrame.GetLocalsPointer<LocalVariables>()->field_13 = 0;
					while ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_4)
					{
						bool num = (startFrame.GetLocalsPointer<LocalVariables>()->field_12 & 1) == 1 && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_13 < (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_12 = (num ? ((sbyte)1) : ((sbyte)0));
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_11 & 1) == 0 && (startFrame.GetLocalsPointer<LocalVariables>()->field_13 & 1) == 0)
						{
							sbyte field_7 = (sbyte)decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_7;
						}
						void* field_8 = Index_97utgsc.Invoke(&((crnd_crn_unpacker*)@this)->field_12, startFrame.GetLocalsPointer<LocalVariables>()->field_13);
						startFrame.GetLocalsPointer<LocalVariables>()->field_14 = field_8;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_11 & 1) != 0)
						{
							sbyte field_9 = (sbyte)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)->field_0;
							startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_9;
						}
						else
						{
							sbyte field_10 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8 & 3);
							startFrame.GetLocalsPointer<LocalVariables>()->field_15 = field_10;
							sbyte field_11 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8 >> 2);
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_11;
							short field_12 = (short)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8 & 3);
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)->field_0 = field_12;
							sbyte field_13 = (sbyte)((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_8 >> 2);
							startFrame.GetLocalsPointer<LocalVariables>()->field_8 = field_13;
						}
						if (startFrame.GetLocalsPointer<LocalVariables>()->field_15 == 0)
						{
							int num2 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
							int field_14 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 + num2;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_14;
							if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_7 >= (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_3)
							{
								int field_15 = startFrame.GetLocalsPointer<LocalVariables>()->field_3;
								int field_16 = startFrame.GetLocalsPointer<LocalVariables>()->field_7 - field_15;
								startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_16;
							}
							short field_17 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)->field_1 = field_17;
						}
						else if ((byte)startFrame.GetLocalsPointer<LocalVariables>()->field_15 == 1)
						{
							short field_18 = (short)startFrame.GetLocalsPointer<LocalVariables>()->field_7;
							((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)->field_1 = field_18;
						}
						else
						{
							int field_19 = (ushort)((crnd_crn_unpacker_block_buffer_element*)startFrame.GetLocalsPointer<LocalVariables>()->field_14)->field_1;
							startFrame.GetLocalsPointer<LocalVariables>()->field_7 = field_19;
						}
						int field_20 = decode.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
						startFrame.GetLocalsPointer<LocalVariables>()->field_16 = field_20;
						if ((startFrame.GetLocalsPointer<LocalVariables>()->field_12 & 1) == 1)
						{
							int num3 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_8, startFrame.GetLocalsPointer<LocalVariables>()->field_7);
							*(int*)startFrame.GetLocalsPointer<LocalVariables>()->field_10 = num3;
							int num4 = *(int*)Index_rfutjka.Invoke(&((crnd_crn_unpacker*)@this)->field_9, startFrame.GetLocalsPointer<LocalVariables>()->field_16);
							((int*)startFrame.GetLocalsPointer<LocalVariables>()->field_10)[1] = num4;
						}
						int field_21 = startFrame.GetLocalsPointer<LocalVariables>()->field_13 + 1;
						startFrame.GetLocalsPointer<LocalVariables>()->field_13 = field_21;
						void* field_22 = (byte*)startFrame.GetLocalsPointer<LocalVariables>()->field_10 + 8;
						startFrame.GetLocalsPointer<LocalVariables>()->field_10 = field_22;
					}
					int field_23 = startFrame.GetLocalsPointer<LocalVariables>()->field_11 + 1;
					startFrame.GetLocalsPointer<LocalVariables>()->field_11 = field_23;
					int field_24 = startFrame.GetLocalsPointer<LocalVariables>()->field_6;
					void* field_25 = startFrame.GetLocalsPointer<LocalVariables>()->field_10;
					startFrame.GetLocalsPointer<LocalVariables>()->field_10 = (byte*)field_25 + (nint)field_24 * (nint)4;
				}
				int field_26 = startFrame.GetLocalsPointer<LocalVariables>()->field_9 + 1;
				startFrame.GetLocalsPointer<LocalVariables>()->field_9 = field_26;
			}
			StackFrameList.Current.Clear(startFrame);
			return true;
		}
	}
}
