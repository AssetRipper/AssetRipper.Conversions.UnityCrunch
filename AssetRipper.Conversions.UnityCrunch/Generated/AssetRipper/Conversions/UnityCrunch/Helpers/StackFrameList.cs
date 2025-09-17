using System;
using System.Collections.Generic;

namespace AssetRipper.Conversions.UnityCrunch.Helpers;

internal partial struct StackFrameList
{
	[ThreadStatic]
	public static StackFrameList Current;

	private List<StackFrame>? Frames;

	public StackFrame New<T>() where T : unmanaged
	{
		if (Frames == null)
		{
			Frames = new List<StackFrame>();
		}
		StackFrame stackFrame = StackFrame.Create<T>(Frames.Count);
		Frames.Add(stackFrame);
		return stackFrame;
	}

	public static void ExitToUserCode()
	{
		if (ExceptionInfo.Current == null)
		{
			Current.Clear();
			return;
		}
		string message = ExceptionInfo.Current.GetMessage();
		ExceptionInfo.Current = null;
		Current.Clear();
		throw new Exception(message);
	}

	internal readonly void Clear()
	{
		if (Frames == null)
		{
			return;
		}
		foreach (StackFrame frame in Frames)
		{
			frame.FreeLocals();
		}
		Frames.Clear();
	}

	internal readonly void Clear(int startIndex)
	{
		for (int num = Frames.Count - 1; num >= startIndex; num--)
		{
			Frames[num].FreeLocals();
		}
		Frames.RemoveRange(startIndex, Frames.Count - startIndex);
	}

	public readonly void Clear(StackFrame startFrame)
	{
		Clear(startFrame.Index);
	}
}
