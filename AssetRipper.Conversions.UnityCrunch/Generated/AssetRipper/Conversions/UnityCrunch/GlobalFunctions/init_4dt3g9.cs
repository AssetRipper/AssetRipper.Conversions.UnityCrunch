using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?init@crn_unpacker@crnd@@QEAA_NPEBXI@Z")]
[DemangledName("public: bool __cdecl crnd::crn_unpacker::init(void const *, unsigned int)")]
[CleanName("init")]
internal static partial class init_4dt3g9
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const *")] void* pData, [NativeType("unsigned int")] int data_size)
	{
		unchecked
		{
			((crnd_crn_unpacker*)@this)->m_pHeader = crnd_get_header.Invoke(pData, data_size);
			if (((crnd_crn_unpacker*)@this)->m_pHeader == null)
			{
				return false;
			}
			((crnd_crn_unpacker*)@this)->m_pData = pData;
			((crnd_crn_unpacker*)@this)->m_data_size = data_size;
			bool flag = init_tables.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag)
			{
				return false;
			}
			bool flag2 = decode_palettes.Invoke(@this);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			if (!flag2)
			{
				return false;
			}
			return true;
		}
	}
}
