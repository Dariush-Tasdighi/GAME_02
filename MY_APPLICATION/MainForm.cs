namespace MY_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public System.Collections.Generic.List<Game.Ball> Balls { get; set; }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			KeyPreview = true;

			Game.Settings settings = new Game.Settings(this)
			{
				BallDiameter = 18,
				BallBackColor = System.Drawing.Color.Yellow,

				RacketSpeed = 24,
				RacketWidth = 120,
				RacketHeight = 4,
				RacketInitialDistance = 30,
				RacketBackColor = System.Drawing.Color.Green,

				BoardWidth = 360,
				BoardHeight = 480,
				BoardBorderThickness = 1,
				BoardBackColor = System.Drawing.Color.Red,
				BoardBorderColor = System.Drawing.Color.Blue,
			};

			Game.Board board =
				new Game.Board(scene: scenePictureBox, settings: settings);

			Game.Racket racket =
				new Game.Racket(scene: scenePictureBox, settings: settings, board: board);

			//string pathName =
			//	Infrastructure.Utility.GetPathName("Space.jpg");

			//if (System.IO.File.Exists(pathName))
			//{
			//	scenePictureBox.ImageLocation = pathName;
			//}

			Balls =
				new System.Collections.Generic.List<Game.Ball>();

			for (int index = 1; index <= 1; index++)
			{
				Game.Ball ball =
					new Game.Ball(scene: scenePictureBox, settings: settings, board: board, racket: racket);

				Balls.Add(ball);
			}
		}

		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}

		private void TopPanel_DoubleClick(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
