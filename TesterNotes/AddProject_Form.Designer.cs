
namespace TesterNotes
{
	partial class AddProject_Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject_Form));
            this.labelAPF_close = new System.Windows.Forms.Label();
            this.buttonAPF_addproject = new System.Windows.Forms.Button();
            this.textBoxAPF_name = new System.Windows.Forms.TextBox();
            this.textBoxAPF_cust = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAPF_close
            // 
            resources.ApplyResources(this.labelAPF_close, "labelAPF_close");
            this.labelAPF_close.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelAPF_close.Name = "labelAPF_close";
            this.labelAPF_close.Click += new System.EventHandler(this.labelAPF_close_Click);
            this.labelAPF_close.MouseEnter += new System.EventHandler(this.labelAPF_close_MouseEnter);
            this.labelAPF_close.MouseLeave += new System.EventHandler(this.labelAPF_close_MouseLeave);
            // 
            // buttonAPF_addproject
            // 
            this.buttonAPF_addproject.BackColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.buttonAPF_addproject, "buttonAPF_addproject");
            this.buttonAPF_addproject.ForeColor = System.Drawing.Color.White;
            this.buttonAPF_addproject.Name = "buttonAPF_addproject";
            this.buttonAPF_addproject.UseVisualStyleBackColor = false;
            this.buttonAPF_addproject.Click += new System.EventHandler(this.buttonAPF_addproject_Click);
            // 
            // textBoxAPF_name
            // 
            resources.ApplyResources(this.textBoxAPF_name, "textBoxAPF_name");
            this.textBoxAPF_name.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAPF_name.Name = "textBoxAPF_name";
            this.textBoxAPF_name.MouseEnter += new System.EventHandler(this.textBoxAPF_name_MouseEnter);
            this.textBoxAPF_name.MouseLeave += new System.EventHandler(this.textBoxAPF_name_MouseLeave);
            // 
            // textBoxAPF_cust
            // 
            resources.ApplyResources(this.textBoxAPF_cust, "textBoxAPF_cust");
            this.textBoxAPF_cust.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAPF_cust.Name = "textBoxAPF_cust";
            this.textBoxAPF_cust.MouseEnter += new System.EventHandler(this.textBoxAPF_cust_MouseEnter);
            this.textBoxAPF_cust.MouseLeave += new System.EventHandler(this.textBoxAPF_cust_MouseLeave);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Name = "label1";
            // 
            // AddProject_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAPF_cust);
            this.Controls.Add(this.textBoxAPF_name);
            this.Controls.Add(this.buttonAPF_addproject);
            this.Controls.Add(this.labelAPF_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProject_Form";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddProject_Form_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAPF_close;
		private System.Windows.Forms.Button buttonAPF_addproject;
		private System.Windows.Forms.TextBox textBoxAPF_name;
		private System.Windows.Forms.TextBox textBoxAPF_cust;
		private System.Windows.Forms.Label label1;
	}
}