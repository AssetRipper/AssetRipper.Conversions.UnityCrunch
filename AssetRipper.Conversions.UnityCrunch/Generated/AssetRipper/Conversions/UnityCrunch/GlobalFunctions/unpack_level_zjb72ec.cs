using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?unpack_level@crn_unpacker@crnd@@QEAA_NPEBXIPEAPEAXIII@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::unpack_level(void const *, unsigned int, void **, unsigned int, unsigned int, unsigned int)")]
[CleanName("unpack_level")]
internal static partial class unpack_level_zjb72ec
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pSrc, [NativeType("unsigned int")] int src_size_in_bytes, [NativeType("void **")] void* pDst, [NativeType("unsigned int")] int dst_size_in_bytes, [NativeType("unsigned int")] int row_pitch_in_bytes, [NativeType("unsigned int")] int level_index)
	{
		int num = row_pitch_in_bytes;
		unchecked
		{
			int num2 = maximum.Invoke(crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_5) >>> level_index, 1);
			int num3 = maximum.Invoke(crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_6) >>> level_index, 1);
			int num4 = num2 + 3 >>> 2;
			int num5 = num3 + 3 >>> 2;
			int num6 = InstructionHelper.Select((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 0) ? true : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 9) ? true : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 10) ? true : ((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) != 11) ? (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 13) : true))), 8, 16) * num4;
			if (num == 0)
			{
				num = num6;
			}
			else if ((uint)num < (uint)num6 || (num & 3) != 0)
			{
				return false;
			}
			if ((uint)dst_size_in_bytes < (uint)(num * num5))
			{
				return false;
			}
			if (!start_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4, pSrc, src_size_in_bytes))
			{
				return false;
			}
			sbyte b;
			switch (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9))
			{
			case 0:
			case 13:
			{
				bool flag2 = unpack_dxt1.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag2 ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 14:
			{
				bool flag6 = unpack_dxt5.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag6 ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			case 9:
			{
				bool flag3 = unpack_dxt5a.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag3 ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			case 7:
			case 8:
			{
				bool flag5 = unpack_dxn.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag5 ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			case 10:
			{
				bool flag7 = unpack_etc1.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag7 ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			case 11:
			{
				bool flag4 = unpack_etc1.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag4 ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			case 12:
			{
				bool flag = unpack_etc2a.Invoke(@this, pDst, num, num4, num5);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				b = (flag ? ((sbyte)1) : ((sbyte)0));
				break;
			}
			default:
				return false;
			}
			if ((b & 1) != 1)
			{
				return false;
			}
			stop_decoding.Invoke(&((crnd_crn_unpacker*)@this)->field_4);
			return true;
		}
	}
}
