namespace Game
{
	public abstract class Base : object
	{
		public Base(System.Windows.Forms.PictureBox scene, Settings settings)
		{
			Scene = scene;
			Settings = settings;

			Scene.Paint += Scene_Paint;

			SceneWidth = Scene.Width;
			SceneHeight = scene.Height;
		}

		public int X { get; protected set; }

		public int Y { get; protected set; }

		public int Width { get; protected set; }

		public int Height { get; protected set; }

		public int SceneWidth { get; protected set; }

		public int SceneHeight { get; protected set; }

		public Settings Settings { get; protected set; }

		protected System.Windows.Forms.PictureBox Scene { get; set; }

		public abstract void Dispose();

		protected virtual void Scene_Paint
			(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			//e.Graphics.CompositingMode =
			//	System.Drawing.Drawing2D.CompositingMode.SourceOver;

			e.Graphics.CompositingQuality =
				System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
		}
	}
}
