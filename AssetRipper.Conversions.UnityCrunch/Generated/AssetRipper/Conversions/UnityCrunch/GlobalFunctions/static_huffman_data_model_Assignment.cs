using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4static_huffman_data_model@crnd@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class crnd::static_huffman_data_model & __cdecl crnd::static_huffman_data_model::operator=(class crnd::static_huffman_data_model const &)")]
internal static partial class static_huffman_data_model_Assignment
{
	[return: NativeType("class crnd::static_huffman_data_model &")]
	public unsafe static void* Invoke(void* @this, [NativeType("class crnd::static_huffman_data_model const &")] void* rhs)
	{
		if (@this == rhs)
		{
			return @this;
		}
		unchecked
		{
			((crnd_static_huffman_data_model*)@this)->m_total_syms = ((crnd_static_huffman_data_model*)rhs)->m_total_syms;
			vector_unsigned_char_Assignment.Invoke(other: &((crnd_static_huffman_data_model*)rhs)->m_code_sizes, @this: &((crnd_static_huffman_data_model*)@this)->m_code_sizes);
			if (ExceptionInfo.Current != null)
			{
				return null;
			}
			if (Get_alloc_failed.Invoke(&((crnd_static_huffman_data_model*)@this)->m_code_sizes))
			{
				clear_9udjtr.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				return @this;
			}
			if (((crnd_static_huffman_data_model*)rhs)->m_pDecode_tables != null)
			{
				if (((crnd_static_huffman_data_model*)@this)->m_pDecode_tables != null)
				{
					decoder_tables_Assignment.Invoke(other: ((crnd_static_huffman_data_model*)rhs)->m_pDecode_tables, @this: ((crnd_static_huffman_data_model*)@this)->m_pDecode_tables);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
				}
				else
				{
					void* pDecode_tables = crnd_new_485jak.Invoke(((crnd_static_huffman_data_model*)rhs)->m_pDecode_tables);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = pDecode_tables;
				}
			}
			else
			{
				crnd_delete_bvucig.Invoke(((crnd_static_huffman_data_model*)@this)->m_pDecode_tables);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				((crnd_static_huffman_data_model*)@this)->m_pDecode_tables = null;
			}
			return @this;
		}
	}
}
