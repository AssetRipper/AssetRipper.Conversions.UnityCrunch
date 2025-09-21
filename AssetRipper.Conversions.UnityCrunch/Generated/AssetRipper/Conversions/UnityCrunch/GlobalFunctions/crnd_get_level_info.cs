using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_get_level_info@crnd@@YA_NPEBXIIPEAUcrn_level_info@1@@Z")]
[DemangledName("bool __cdecl crnd::crnd_get_level_info(void const *, unsigned int, unsigned int, struct crnd::crn_level_info *)")]
internal static partial class crnd_get_level_info
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke([NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size, [NativeType("unsigned int")] int level_index, [NativeType("struct crnd::crn_level_info *")] void* pLevel_info)
	{
		unchecked
		{
			if (pData == null || (uint)data_size < 62u || pLevel_info == null)
			{
				return false;
			}
			if ((long)(uint)((crnd_crn_level_info*)pLevel_info)->field_0 != 32L)
			{
				return false;
			}
			void* ptr = crnd_get_header.Invoke(pData, data_size);
			if (ptr == null)
			{
				return false;
			}
			if ((uint)level_index >= (uint)crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_7))
			{
				return false;
			}
			int num = maximum.Invoke(1, crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_5) >>> level_index);
			int num2 = maximum.Invoke(1, crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_6) >>> level_index);
			((crnd_crn_level_info*)pLevel_info)->field_1 = num;
			((crnd_crn_level_info*)pLevel_info)->field_2 = num2;
			((crnd_crn_level_info*)pLevel_info)->field_3 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_8);
			((crnd_crn_level_info*)pLevel_info)->field_4 = num + 3 >>> 2;
			((crnd_crn_level_info*)pLevel_info)->field_5 = num2 + 3 >>> 2;
			((crnd_crn_level_info*)pLevel_info)->field_6 = InstructionHelper.Select((crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9) != 0) ? (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9) == 9) : true, 8, 16);
			((crnd_crn_level_info*)pLevel_info)->field_7 = crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)ptr)->field_9);
			return true;
		}
	}
}
