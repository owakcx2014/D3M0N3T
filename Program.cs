using System;
using System.Windows.Forms;

namespace D3M0N3T
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// 1.  ‘€Ì· «·‘«‘… «· —ÕÌ»Ì…
			// ‰” Œœ„ «·«”„ «·ﬂ«„· „⁄ global:: ·≈Œ»«— «·„ —Ã„ √‰ Ì»ÕÀ ›Ì «·‹ Namespace 
			// Ê·Ì” œ«Œ· ﬂ·«” D3M0N3T «·√”«”Ì
			using (global::D3M0N3T.SplashScreen splash = new global::D3M0N3T.SplashScreen())
			{
				splash.Show();
				Application.DoEvents();

				// „œ… ŸÂÊ— «·‘«‘… (À«‰Ì Ì‰)
				System.Threading.Thread.Sleep(5000);

				splash.Close();
			}

			// 2.  ‘€Ì· «·›Ê—„ «·√”«”Ì («·–Ì ÌÕ„· ‰›” «”„ «·„‘—Ê⁄)
			Application.Run(new global::D3M0N3T.D3M0N3T());
		}
	}
}