using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@E@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned char>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_zpvfc7
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size)
	{
		unchecked
		{
			if (((crnd_vector_uksit8*)@this)->m_size != new_size)
			{
				if ((uint)new_size < (uint)((crnd_vector_uksit8*)@this)->m_size)
				{
					destruct_array_s3iq3j.Invoke(parameter_1: ((crnd_vector_uksit8*)@this)->m_size - new_size, parameter_0: (byte*)((crnd_vector_uksit8*)@this)->m_p + (uint)new_size);
				}
				else
				{
					if ((uint)new_size > (uint)((crnd_vector_uksit8*)@this)->m_capacity)
					{
						bool flag = increase_capacity_2iysmi.Invoke(@this, new_size, new_size == ((crnd_vector_uksit8*)@this)->m_size + 1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_mseefg.Invoke(n: new_size - ((crnd_vector_uksit8*)@this)->m_size, p: (byte*)((crnd_vector_uksit8*)@this)->m_p + (uint)((crnd_vector_uksit8*)@this)->m_size);
				}
				((crnd_vector_uksit8*)@this)->m_size = new_size;
			}
			return true;
		}
	}
}
