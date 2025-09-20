using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init@crn_unpacker@crnd@@QEAA_NPEBXI@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::init(void const *, unsigned int)")]
[CleanName("init")]
internal static partial class init_lqqdgrc
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size)
	{
		bool flag = false;
		unchecked
		{
			((crnd_crn_unpacker*)@this)->field_3 = crnd_get_header.Invoke(pData, data_size);
			if (((crnd_crn_unpacker*)@this)->field_3 == null)
			{
				return false;
			}
			((crnd_crn_unpacker*)@this)->field_1 = pData;
			((crnd_crn_unpacker*)@this)->field_2 = data_size;
			bool flag2 = init_tables.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			bool flag3 = decode_palettes.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag3)
			{
				return false;
			}
			return true;
		}
	}
}
