using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4decoder_tables@prefix_coding@crnd@@QEAAAEAV012@AEBV012@@Z")]
[DemangledName("public: class crnd::prefix_coding::decoder_tables & __cdecl crnd::prefix_coding::decoder_tables::operator=(class crnd::prefix_coding::decoder_tables const &)")]
internal static partial class _4decoder_tables
{
	private partial struct LocalVariables
	{
		public unsafe void* field_0;

		public unsafe void* field_1;
	}

	public unsafe static void* Invoke(void* @this, void* other)
	{
		StackFrame startFrame = StackFrameList.Current.New<LocalVariables>();
		startFrame.GetLocalsPointer<LocalVariables>()->field_0 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = null;
		startFrame.GetLocalsPointer<LocalVariables>()->field_1 = other;
		unchecked
		{
			if (@this == startFrame.GetLocalsPointer<LocalVariables>()->field_1)
			{
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = @this;
			}
			else
			{
				clear_ie5thac.Invoke(@this);
				if (ExceptionInfo.Current != null)
				{
					return null;
				}
				llvm_memcpy_p0_p0_i64.Invoke(@this, startFrame.GetLocalsPointer<LocalVariables>()->field_1, 192L, isVolatile: false);
				if (((crnd_prefix_coding_decoder_tables*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_11 != null)
				{
					void* field_ = crnd_new_array_linsntd.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_10);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					((crnd_prefix_coding_decoder_tables*)@this)->field_11 = field_;
					if (((crnd_prefix_coding_decoder_tables*)@this)->field_11 != null)
					{
						llvm_memcpy_p0_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_11, ((crnd_prefix_coding_decoder_tables*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_11, 4L * (long)(uint)((crnd_prefix_coding_decoder_tables*)@this)->field_10, isVolatile: false);
					}
				}
				if (((crnd_prefix_coding_decoder_tables*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_13 != null)
				{
					void* field_2 = crnd_new_array_ovofsdb.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_12);
					if (ExceptionInfo.Current != null)
					{
						return null;
					}
					((crnd_prefix_coding_decoder_tables*)@this)->field_13 = field_2;
					if (((crnd_prefix_coding_decoder_tables*)@this)->field_13 != null)
					{
						llvm_memcpy_p0_p0_i64.Invoke(((crnd_prefix_coding_decoder_tables*)@this)->field_13, ((crnd_prefix_coding_decoder_tables*)startFrame.GetLocalsPointer<LocalVariables>()->field_1)->field_13, 2L * (long)(uint)((crnd_prefix_coding_decoder_tables*)@this)->field_12, isVolatile: false);
					}
				}
				startFrame.GetLocalsPointer<LocalVariables>()->field_0 = @this;
			}
			void* field_3 = startFrame.GetLocalsPointer<LocalVariables>()->field_0;
			StackFrameList.Current.Clear(startFrame);
			return field_3;
		}
	}
}
