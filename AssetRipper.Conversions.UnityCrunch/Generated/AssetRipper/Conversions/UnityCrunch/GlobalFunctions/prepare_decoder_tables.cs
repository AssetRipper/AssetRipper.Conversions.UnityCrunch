using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?prepare_decoder_tables@static_huffman_data_model@crnd@@AEAA_NXZ")]
[DemangledName("private: bool __cdecl crnd::static_huffman_data_model::prepare_decoder_tables(void)")]
internal static partial class prepare_decoder_tables
{
	private partial struct LocalVariables
	{
		public int field_0;
	}

	public unsafe static bool Invoke(void* @this)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = 0;
		unchecked
		{
			int field_ = size_23co4id.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1);
			startFrame.GetLocalsPointer<LocalVariables>()->field_0 = field_;
			int num;
			if ((uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 >= 1u && (uint)startFrame.GetLocalsPointer<LocalVariables>()->field_0 <= 8192u)
			{
				num = -1;
			}
			else
			{
				crnd_assert.Invoke(String_3h2uiyd.__pointer, String_yguirrd.__pointer, 2468);
				num = 0;
			}
			((crnd_static_huffman_data_model*)@this)->field_0 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			if (((crnd_static_huffman_data_model*)@this)->field_2 == null)
			{
				void* field_2 = crnd_new_9bg4xgd.Invoke();
				if (ExceptionInfo.Current != null)
				{
					return false;
				}
				((crnd_static_huffman_data_model*)@this)->field_2 = field_2;
			}
			bool result = init_igqra9d.Invoke(((crnd_static_huffman_data_model*)@this)->field_2, table_bits: compute_decoder_table_bits.Invoke(@this), pCodesizes: Index_o39mi9c.Invoke(&((crnd_static_huffman_data_model*)@this)->field_1, 0), num_syms: ((crnd_static_huffman_data_model*)@this)->field_0);
			if (ExceptionInfo.Current != null)
			{
				return false;
			}
			StackFrameList.Current.Clear(startFrame);
			return result;
		}
	}
}
