/*

Game Dev POE Part 1 
Tinashe Muneri - ST10438060
Gift Zowa - ST10443108

 */

using System;

namespace GameDevPOE
{
    internal static class Program
    {
        /// <summary>
        ///Main Program of POE
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 form1 = new Form1();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}