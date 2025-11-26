using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@I@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned int>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_dreg6y
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size)
	{
		unchecked
		{
			if (((crnd_vector_rgfndh*)@this)->m_size != new_size)
			{
				if ((uint)new_size < (uint)((crnd_vector_rgfndh*)@this)->m_size)
				{
					destruct_array_h4d2m4.Invoke(parameter_1: ((crnd_vector_rgfndh*)@this)->m_size - new_size, parameter_0: (byte*)((crnd_vector_rgfndh*)@this)->m_p + (nint)(uint)new_size * (nint)4);
				}
				else
				{
					if ((uint)new_size > (uint)((crnd_vector_rgfndh*)@this)->m_capacity)
					{
						bool flag = increase_capacity_r6etif.Invoke(@this, new_size, new_size == ((crnd_vector_rgfndh*)@this)->m_size + 1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_5nd2vv.Invoke(n: new_size - ((crnd_vector_rgfndh*)@this)->m_size, p: (byte*)((crnd_vector_rgfndh*)@this)->m_p + (nint)(uint)((crnd_vector_rgfndh*)@this)->m_size * (nint)4);
				}
				((crnd_vector_rgfndh*)@this)->m_size = new_size;
			}
			return true;
		}
	}
}
