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
		unchecked
		{
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, buf_size: crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_tables_size), pBuf: (byte*)((crnd_crn_unpacker*)@this)->m_pData + (uint)crn_packed_uint_3_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_tables_ofs)))
			{
				return false;
			}
			bool flag = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_reference_encoding_dm);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_num) == 0 && crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_num) == 0)
			{
				return false;
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_color_endpoints.m_num) != 0)
			{
				bool flag2 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					return false;
				}
				bool flag3 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, &((crnd_crn_unpacker*)@this)->m_selector_delta_dm);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag3)
				{
					return false;
				}
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->m_pHeader)->m_alpha_endpoints.m_num) != 0)
			{
				bool flag4 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_endpoint_delta_dm) + sizeof(crnd_static_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag4)
				{
					return false;
				}
				bool flag5 = decode_receive_static_data_model.Invoke(&((crnd_crn_unpacker*)@this)->m_codec, (byte*)(&((crnd_crn_unpacker*)@this)->m_selector_delta_dm) + sizeof(crnd_static_huffman_data_model));
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag5)
				{
					return false;
				}
			}
			stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->m_codec);
			return true;
		}
	}
}
