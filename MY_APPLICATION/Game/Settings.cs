namespace Game
{
	public class Settings : object
	{
		public Settings(System.Windows.Forms.Form form)
		{
			Form = form;
		}

		public int BallDiameter { get; set; }

		public System.Drawing.Color BallBackColor { get; set; }



		public System.Windows.Forms.Form Form { get; set; }



		public int RacketWidth { get; set; }

		public int RacketHeight { get; set; }

		public int RacketSpeed { get; set; }

		public int RacketInitialDistance { get; set; }

		public System.Drawing.Color RacketBackColor { get; set; }



		public int BoardWidth { get; set; }

		public int BoardHeight { get; set; }

		public int BoardBorderThickness { get; set; }

		public System.Drawing.Color BoardBackColor { get; set; }

		public System.Drawing.Color BoardBorderColor { get; set; }
	}
}
