using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using Microsoft.WindowsCE.Forms;
using System.Text;

namespace STM7700BCR
{
	/// <summary>
	/// Functions and variables for the STM7100 Barcode Scanner (MSR_DLL.dll).
	/// </summary>
	
	public class STM7700BCRDLL
	{
        public const uint WM_COPYDATA = 0x4A;

        [DllImport(@"WJST_2DScannerAPI.dll")]
        public static extern int WJST_2DScannerInit(IntPtr hWndApp);

        [DllImport(@"WJST_2DScannerAPI.dll")]
        public static extern int WJST_2DScannerDeInit();

        [DllImport(@"WJST_2DScannerAPI.dll")]
        public static extern int WJST_2DScannerShowVersion();
	}
}
