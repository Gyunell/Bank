namespace Winform_Course;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        label1 = new Label();
        label1.Location = new Point(140, 70);
        label1.Name = "Label1";
        label1.Text = "Meblegi daxil et";
        label1.ForeColor = Color.Black;
        this.Controls.Add(label1);

        label3 = new Label();
        label3.Location = new Point(140, 90);
        label3.Name = "Label3";
        label3.Text = "Mebleginiz azdir";
        label3.ForeColor = Color.Red;
        label3.Visible = false;
        this.Controls.Add(label3);

        textBox1 = new TextBox();
        textBox1.Location = new Point(140, 120);
        textBox1.Name = "Textbox2";
        textBox1.Width = 500;
        textBox1.Height = 500;
        this.Controls.Add(textBox1);

        label2 = new Label();
        label2.Location = new Point(330, 160);
        label2.Name = "Label2";
        label2.Text = "Mebleg : 0 manat";
        label2.Width = 200;
        label2.ForeColor = Color.Black;
        this.Controls.Add(label2);

        button1 = new Button();
        button1.Location = new Point(140, 210);
        button1.Name = "Button1";
        button1.Text = "Elave et";
        button1.Width = 180;
        button1.Height = 60;
        button1.ForeColor = Color.White;
        button1.BackColor = Color.Green;
        this.Controls.Add(button1);

        button2 = new Button();
        button2.Location = new Point(440, 210);
        button2.Name = "Button1";
        button2.Text = "Cek";
        button2.Width = 180;
        button2.Height = 60;
        button2.ForeColor = Color.White;
        button2.BackColor = Color.Red;
        this.Controls.Add(button2);
    }

    private Label label1;
    private Label label3;
    private TextBox textBox1;
    private Label label2;
    private Button button1;
    private Button button2;

    #endregion
}
