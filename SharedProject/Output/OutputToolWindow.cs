using System;
using Microsoft.VisualStudio.Shell;
using System.Runtime.InteropServices;

namespace FineCodeCoverage.Output
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("320fd13f-632f-4b16-9527-a1adfe555f6c")]
	internal class OutputToolWindow : ToolWindowPane
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OutputToolWindow"/> class.
		/// </summary>
		public OutputToolWindow(OutputToolWindowContext context) : base(null)
		{
		}

		/*
		    no exception with this present 2022 debugging - but the context ctor should be used anyway    


		    public OutputToolWindow()
            {
		    }
		*/

		
    }
}
