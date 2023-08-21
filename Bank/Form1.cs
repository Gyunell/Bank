namespace Winform_Course;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        //     Label l = new Label();
        //     Point yerlesme = new Point(320,40);
        //     l.Name = "Label";
        //     l.Location = yerlesme;
        //     l.Text = "Adinizi daxil edin";
        //     l.ForeColor = Color.Black;
        //     this.Controls.Add(l);

        //     TextBox t = new TextBox();
        //     Point yerlesme3 = new Point(320,60);
        //     t.Name = "TextBox";
        //     t.Location = yerlesme3;
        //     this.Controls.Add(t);

        //     Label l1 = new Label();
        //     Point yerlesme4 = new Point(320,100);
        //     l1.Name = "Label1";
        //     l1.Location = yerlesme4;
        //     l1.Text = "Soyadinizi daxil edin";
        //     l1.ForeColor = Color.Black;
        //     this.Controls.Add(l1);

        //     TextBox t1 = new TextBox();
        //     Point yerlesme5 = new Point(320,120);
        //     t1.Name = "TextBox1";
        //     t1.Location = yerlesme5;
        //     this.Controls.Add(t1);

        //     Label l2 = new Label();
        //     Point yerlesme6 = new Point (320,160);
        //     l2.Name = "Labell2";
        //     l2.Location = yerlesme6;
        //     l2.Text = "Gmailinizi daxil edin";
        //     l2.ForeColor = Color.Black;
        //     this.Controls.Add(l2);

        //     TextBox t2 = new TextBox ();
        //     Point yerlesme7 = new Point(320,180);
        //     t2.Name = "TextBox2";
        //     t2.Location = yerlesme7;
        //     this.Controls.Add(t2);

        //    Button b = new Button();
        //    Point yerlesme2 = new Point(320,220);
        //    b.Name = "Button1";
        //    b.Location = yerlesme2;
        //    b.Text = "Giris edin";
        //    b.Width = 100;
        //    b.ForeColor = Color.Black;
        //    this.Controls.Add(b);

        //    Label l3 = new Label();
        //    Point yerlesme8 = new Point(345,250);
        //    l3.Name = "Labell3";
        //    l3.Location = yerlesme8;
        //    l3.Text = "Sehvdir";
        //    l3.ForeColor = Color.Red;
        //    this.Controls.Add(l3);

        // Label l = new Label();
        // Point yer = new Point (140,80);
        // l.Name = "Label1";
        // l.Location = yer;
        // l.Text = "Meblegi daxil et";
        // l.ForeColor = Color.Black;
        // this.Controls.Add(l);

        // TextBox t = new TextBox();
        // Point yer2 = new Point (140,110);
        // t.Name = "Textbox2";
        // t.Location = yer2;
        // t.Width = 500;
        // t.Height = 500;
        // this.Controls.Add(t);

        // Label l2 = new Label();
        // Point yer3 = new Point (330,160);
        // l2.Name = "Label2";
        // l2.Location = yer3;
        // l2.Text = "Mebleg : 100 manat";
        // l2.Width = 200;
        // l2.ForeColor = Color.Black;
        // this.Controls.Add(l2);

        // Button b = new Button();
        // Point yer4 = new Point(140,210);
        // b.Name = "Button1";
        // b.Location = yer4;
        // b.Text = "Elave et";
        // b.Width = 180;
        // b.Height = 60;
        // b.ForeColor = Color.White;
        // b.BackColor = Color.Green;
        // this.Controls.Add(b);

        // Button b2 = new Button();
        // Point yer5 = new Point(440,210);
        // b2.Name = "Button1";
        // b2.Location = yer5;
        // b2.Text = "Cek";
        // b2.Width = 180;
        // b2.Height = 60;
        // b2.ForeColor = Color.White;
        // b2.BackColor = Color.Red;
        // this.Controls.Add(b2);
         
        button1.Click += button1_Click;
        button2.Click += button2_Click;
    }

    
    decimal price = 0; decimal total = 0;
    private void button1_Click(object sender, EventArgs e)
    {
        price = Convert.ToDecimal(textBox1.Text);
        total = total + price;
        label2.Text = $"Mebleg :{total} manat";
    }
    private void button2_Click(object sender, EventArgs e)
    {
        price = Convert.ToDecimal(textBox1.Text);
        if (price > total)
        {
            label3.Visible = true;
            label2.Text = $"Mebleg :{total} manat";
        }
        else
        {
            label3.Visible = false;
            total = total - price;
            label2.Text = $"Mebleg :{total} manat";
        }
    }
}
