using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?decode_palettes@crn_unpacker@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::crn_unpacker::decode_palettes(void)")]
internal static partial class decode_palettes
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this)
	{
		unchecked
		{
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_14.field_2) != 0)
			{
				bool flag = decode_color_endpoints.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag)
				{
					return false;
				}
				bool flag2 = decode_color_selectors.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag2)
				{
					return false;
				}
			}
			if (crn_packed_uint_2_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_16.field_2) != 0)
			{
				bool flag3 = decode_alpha_endpoints.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				if (!flag3)
				{
					return false;
				}
				if (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 14)
				{
					bool flag4 = decode_alpha_selectors_etcs.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag4)
					{
						goto IL_0118;
					}
				}
				else if (crn_packed_uint_1_ToUInt32.Invoke(&((crnd_crn_header*)((crnd_crn_unpacker*)@this)->field_3)->field_9) == 12)
				{
					bool flag5 = decode_alpha_selectors_etc.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag5)
					{
						goto IL_0118;
					}
				}
				else
				{
					bool flag6 = decode_alpha_selectors.Invoke(@this);
					if (ExceptionInfo.Current != null)
					{
						return false;
					}
					if (!flag6)
					{
						goto IL_0118;
					}
				}
			}
			return true;
		}
		IL_0118:
		return false;
	}
}
