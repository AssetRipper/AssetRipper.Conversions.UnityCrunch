using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init_tables@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::init_tables(void)")]
internal static partial class init_tables
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		bool flag = false;
		unchecked
		{
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, buf_size: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_18), pBuf: (byte*)((crnd_crn_unpacker*)@this)->field_1 + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_19)))
			{
				return false;
			}
			bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_5);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2) == 0 && crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2) == 0)
			{
				return false;
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2) != 0)
			{
				bool flag3 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_6);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag3)
				{
					return false;
				}
				bool flag4 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, &((crnd_crn_unpacker*)@this)->field_7);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag4)
				{
					return false;
				}
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2) != 0)
			{
				bool flag5 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_6) + sizeof(crnd_static_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag5)
				{
					return false;
				}
				bool flag6 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->field_4, (byte*)(&((crnd_crn_unpacker*)@this)->field_7) + sizeof(crnd_static_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag6)
				{
					return false;
				}
			}
			stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
			return true;
		}
	}
}
