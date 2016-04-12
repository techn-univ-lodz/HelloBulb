
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action BulbAction;
	
	private global::Gtk.Action yesAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action cancelAction;
	
	private global::Gtk.Action DimmAction;
	
	private global::Gtk.Action AboutAction1;
	
	private global::Gtk.Action AboutAction2;
	
	private global::Gtk.Fixed fixed2;
	
	private global::Gtk.ToggleButton togglebutton1;
	
	private global::Gtk.Button buttonOFF;
	
	private global::Gtk.Button buttonON;
	
	private global::Gtk.SpinButton spinbuttonDimmer;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.Image image1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.BulbAction = new global::Gtk.Action ("BulbAction", global::Mono.Unix.Catalog.GetString ("Bulb!"), null, null);
		this.BulbAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Bulb!");
		w1.Add (this.BulbAction, null);
		this.yesAction = new global::Gtk.Action ("yesAction", global::Mono.Unix.Catalog.GetString ("ON"), null, "gtk-yes");
		this.yesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("ON");
		w1.Add (this.yesAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About..."), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About...");
		w1.Add (this.AboutAction, null);
		this.cancelAction = new global::Gtk.Action ("cancelAction", global::Mono.Unix.Catalog.GetString ("OFF"), null, "gtk-cancel");
		this.cancelAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("OFF");
		w1.Add (this.cancelAction, null);
		this.DimmAction = new global::Gtk.Action ("DimmAction", global::Mono.Unix.Catalog.GetString ("Dimm"), null, null);
		this.DimmAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Dimm");
		w1.Add (this.DimmAction, null);
		this.AboutAction1 = new global::Gtk.Action ("AboutAction1", global::Mono.Unix.Catalog.GetString ("About..."), null, null);
		this.AboutAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("About...");
		w1.Add (this.AboutAction1, null);
		this.AboutAction2 = new global::Gtk.Action ("AboutAction2", global::Mono.Unix.Catalog.GetString ("About..."), null, null);
		this.AboutAction2.ShortLabel = global::Mono.Unix.Catalog.GetString ("About...");
		w1.Add (this.AboutAction2, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.togglebutton1 = new global::Gtk.ToggleButton ();
		this.togglebutton1.WidthRequest = 121;
		this.togglebutton1.CanFocus = true;
		this.togglebutton1.Name = "togglebutton1";
		this.togglebutton1.UseUnderline = true;
		this.togglebutton1.Active = true;
		this.togglebutton1.Label = global::Mono.Unix.Catalog.GetString ("Przełącz (...)");
		this.fixed2.Add (this.togglebutton1);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.togglebutton1]));
		w2.Y = 479;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.buttonOFF = new global::Gtk.Button ();
		this.buttonOFF.WidthRequest = 80;
		this.buttonOFF.CanFocus = true;
		this.buttonOFF.Name = "buttonOFF";
		this.buttonOFF.UseUnderline = true;
		this.buttonOFF.Label = global::Mono.Unix.Catalog.GetString ("OFF");
		this.fixed2.Add (this.buttonOFF);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.buttonOFF]));
		w3.X = 369;
		w3.Y = 480;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.buttonON = new global::Gtk.Button ();
		this.buttonON.WidthRequest = 80;
		this.buttonON.CanFocus = true;
		this.buttonON.Name = "buttonON";
		this.buttonON.UseUnderline = true;
		this.buttonON.Label = global::Mono.Unix.Catalog.GetString ("ON");
		this.fixed2.Add (this.buttonON);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.buttonON]));
		w4.X = 369;
		w4.Y = 451;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.spinbuttonDimmer = new global::Gtk.SpinButton (0, 100, 1);
		this.spinbuttonDimmer.CanFocus = true;
		this.spinbuttonDimmer.Name = "spinbuttonDimmer";
		this.spinbuttonDimmer.Adjustment.PageIncrement = 10;
		this.spinbuttonDimmer.ClimbRate = 1;
		this.spinbuttonDimmer.Numeric = true;
		this.fixed2.Add (this.spinbuttonDimmer);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.spinbuttonDimmer]));
		w5.X = 207;
		w5.Y = 479;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='BulbAction' action='BulbAction'><menuitem name='yesAction' action='yesAction'/><menuitem name='cancelAction' action='cancelAction'/><menuitem name='DimmAction' action='DimmAction'/></menu><menu name='AboutAction' action='AboutAction'><menuitem name='AboutAction2' action='AboutAction2'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.fixed2.Add (this.menubar1);
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.image1 = new global::Gtk.Image ();
		this.image1.WidthRequest = 450;
		this.image1.HeightRequest = 400;
		this.image1.Name = "image1";
		this.fixed2.Add (this.image1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.image1]));
		w7.X = 1;
		w7.Y = 25;
		this.Add (this.fixed2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 451;
		this.DefaultHeight = 509;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.yesAction.Activated += new global::System.EventHandler (this.bulb_on);
		this.AboutAction2.Activated += new global::System.EventHandler (this.about);
	}
}
