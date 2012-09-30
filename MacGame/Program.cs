#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace maker
{
	static class Program
	{
		private static GameMain game;
    private static Editor editor;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main ()
		{
      bool editorMode = false;
      if(editorMode){
        editor = new Editor();
        editor.Run();
      }
      else{
        game = new GameMain ();
        game.Run ();
      }
			
		}
	}
}
