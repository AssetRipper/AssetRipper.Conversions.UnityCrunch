using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?resize@?$vector@G@crnd@@QEAA_NI@Z")]
[DemangledName("public: bool __cdecl crnd::vector<unsigned short>::resize(unsigned int)")]
[CleanName("resize")]
internal static partial class resize_w95s75a
{
	[return: NativeType("bool")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned int")] int new_size)
	{
		unchecked
		{
			if (((crnd_vector_rf9iywd*)@this)->m_size != new_size)
			{
				if ((uint)new_size < (uint)((crnd_vector_rf9iywd*)@this)->m_size)
				{
					destruct_array_l9jmj2b.Invoke(parameter_1: ((crnd_vector_rf9iywd*)@this)->m_size - new_size, parameter_0: (byte*)((crnd_vector_rf9iywd*)@this)->m_p + (nint)(uint)new_size * (nint)2);
				}
				else
				{
					if ((uint)new_size > (uint)((crnd_vector_rf9iywd*)@this)->m_capacity)
					{
						bool flag = increase_capacity_rjagtyd.Invoke(@this, new_size, new_size == ((crnd_vector_rf9iywd*)@this)->m_size + 1);
						if (ExceptionInfo.Current != null)
						{
							return false;
						}
						if (!flag)
						{
							return false;
						}
					}
					construct_array_gqnztta.Invoke(n: new_size - ((crnd_vector_rf9iywd*)@this)->m_size, p: (byte*)((crnd_vector_rf9iywd*)@this)->m_p + (nint)(uint)((crnd_vector_rf9iywd*)@this)->m_size * (nint)2);
				}
				((crnd_vector_rf9iywd*)@this)->m_size = new_size;
			}
			return true;
		}
	}
}
