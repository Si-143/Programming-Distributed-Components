namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PriceC = new ClassLibrary1.PriceCheck(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ADbox = new System.Windows.Forms.TextBox();
            this.aEmail = new System.Windows.Forms.TextBox();
            this.aAddress = new System.Windows.Forms.TextBox();
            this.aType = new System.Windows.Forms.TextBox();
            this.aPost = new System.Windows.Forms.TextBox();
            this.aName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Change = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Ecomp = new ClassLibrary1.PriceCheck(this.components);
            this.eAD = new System.Windows.Forms.TextBox();
            this.eEmail = new System.Windows.Forms.TextBox();
            this.eAddress = new System.Windows.Forms.TextBox();
            this.eType = new System.Windows.Forms.TextBox();
            this.ePost = new System.Windows.Forms.TextBox();
            this.eName = new System.Windows.Forms.TextBox();
            this.comP1690_RestaurantsTableAdapter1 = new WindowsFormsApplication1.ts348DataSetTableAdapters.COMP1690_RestaurantsTableAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.cOMP1690RestaurantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMP1690_RestaurantsTableAdapter = new WindowsFormsApplication1.ts348DataSet1TableAdapters.COMP1690_RestaurantsTableAdapter();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restaurantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMP1690RestaurantsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ts348DataSet2 = new WindowsFormsApplication1.ts348DataSet2();
            this.ts348DataSet1 = new WindowsFormsApplication1.ts348DataSet();
            this.cOMP1690_RestaurantsTableAdapter2 = new WindowsFormsApplication1.ts348DataSet2TableAdapters.COMP1690_RestaurantsTableAdapter();
            this.Search = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1690RestaurantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1690RestaurantsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts348DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts348DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceC
            // 
            this.PriceC.Location = new System.Drawing.Point(16, 176);
            this.PriceC.Name = "PriceC";
            this.PriceC.Size = new System.Drawing.Size(100, 20);
            this.PriceC.TabIndex = 0;
            this.PriceC.TextChanged += new System.EventHandler(this.PriceC_TextChanged_1);
            this.PriceC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceC_KeyPress_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(27, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(352, 373);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Upload);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.PriceC);
            this.tabPage1.Controls.Add(this.ADbox);
            this.tabPage1.Controls.Add(this.aEmail);
            this.tabPage1.Controls.Add(this.aAddress);
            this.tabPage1.Controls.Add(this.aType);
            this.tabPage1.Controls.Add(this.aPost);
            this.tabPage1.Controls.Add(this.aName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(344, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(186, 173);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(75, 23);
            this.Upload.TabIndex = 8;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(152, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 143);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ADbox
            // 
            this.ADbox.Location = new System.Drawing.Point(17, 260);
            this.ADbox.Name = "ADbox";
            this.ADbox.Size = new System.Drawing.Size(100, 20);
            this.ADbox.TabIndex = 5;
            this.ADbox.Text = "ad Type";
            // 
            // aEmail
            // 
            this.aEmail.Location = new System.Drawing.Point(17, 220);
            this.aEmail.Name = "aEmail";
            this.aEmail.Size = new System.Drawing.Size(100, 20);
            this.aEmail.TabIndex = 4;
            this.aEmail.Text = "Email";
            // 
            // aAddress
            // 
            this.aAddress.Location = new System.Drawing.Point(17, 150);
            this.aAddress.Name = "aAddress";
            this.aAddress.Size = new System.Drawing.Size(100, 20);
            this.aAddress.TabIndex = 3;
            this.aAddress.Text = "Address";
            // 
            // aType
            // 
            this.aType.Location = new System.Drawing.Point(14, 106);
            this.aType.Name = "aType";
            this.aType.Size = new System.Drawing.Size(100, 20);
            this.aType.TabIndex = 2;
            this.aType.Text = "aType";
            // 
            // aPost
            // 
            this.aPost.Location = new System.Drawing.Point(17, 64);
            this.aPost.Name = "aPost";
            this.aPost.Size = new System.Drawing.Size(100, 20);
            this.aPost.TabIndex = 1;
            this.aPost.Text = "PostCode";
            // 
            // aName
            // 
            this.aName.Location = new System.Drawing.Point(17, 24);
            this.aName.Name = "aName";
            this.aName.Size = new System.Drawing.Size(100, 20);
            this.aName.TabIndex = 0;
            this.aName.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Change);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.Ecomp);
            this.tabPage2.Controls.Add(this.eAD);
            this.tabPage2.Controls.Add(this.eEmail);
            this.tabPage2.Controls.Add(this.eAddress);
            this.tabPage2.Controls.Add(this.eType);
            this.tabPage2.Controls.Add(this.ePost);
            this.tabPage2.Controls.Add(this.eName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(344, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(194, 169);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 18;
            this.Change.Text = "upload";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(156, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 131);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ecomp
            // 
            this.Ecomp.Location = new System.Drawing.Point(19, 184);
            this.Ecomp.Name = "Ecomp";
            this.Ecomp.Size = new System.Drawing.Size(100, 20);
            this.Ecomp.TabIndex = 9;
            // 
            // eAD
            // 
            this.eAD.Location = new System.Drawing.Point(20, 268);
            this.eAD.Name = "eAD";
            this.eAD.Size = new System.Drawing.Size(100, 20);
            this.eAD.TabIndex = 15;
            this.eAD.Text = "ad Type";
            // 
            // eEmail
            // 
            this.eEmail.Location = new System.Drawing.Point(20, 228);
            this.eEmail.Name = "eEmail";
            this.eEmail.Size = new System.Drawing.Size(100, 20);
            this.eEmail.TabIndex = 14;
            this.eEmail.Text = "Email";
            // 
            // eAddress
            // 
            this.eAddress.Location = new System.Drawing.Point(20, 158);
            this.eAddress.Name = "eAddress";
            this.eAddress.Size = new System.Drawing.Size(100, 20);
            this.eAddress.TabIndex = 13;
            this.eAddress.Text = "Address";
            // 
            // eType
            // 
            this.eType.Location = new System.Drawing.Point(17, 114);
            this.eType.Name = "eType";
            this.eType.Size = new System.Drawing.Size(100, 20);
            this.eType.TabIndex = 12;
            this.eType.Text = "Type";
            // 
            // ePost
            // 
            this.ePost.Location = new System.Drawing.Point(20, 72);
            this.ePost.Name = "ePost";
            this.ePost.Size = new System.Drawing.Size(100, 20);
            this.ePost.TabIndex = 11;
            this.ePost.Text = "PostCode";
            // 
            // eName
            // 
            this.eName.Location = new System.Drawing.Point(20, 32);
            this.eName.Name = "eName";
            this.eName.Size = new System.Drawing.Size(100, 20);
            this.eName.TabIndex = 10;
            this.eName.Text = "Name";
            // 
            // comP1690_RestaurantsTableAdapter1
            // 
            this.comP1690_RestaurantsTableAdapter1.ClearBeforeFill = true;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // cOMP1690_RestaurantsTableAdapter
            // 
            this.cOMP1690_RestaurantsTableAdapter.ClearBeforeFill = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(395, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(100, 20);
            this.SearchBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.restaurantIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMP1690RestaurantsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(395, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 347);
            this.dataGridView1.TabIndex = 4;
            // 
            // restaurantIDDataGridViewTextBoxColumn
            // 
            this.restaurantIDDataGridViewTextBoxColumn.DataPropertyName = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn.HeaderText = "RestaurantID";
            this.restaurantIDDataGridViewTextBoxColumn.Name = "restaurantIDDataGridViewTextBoxColumn";
            this.restaurantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cOMP1690RestaurantsBindingSource1
            // 
            this.cOMP1690RestaurantsBindingSource1.DataMember = "COMP1690_Restaurants";
            this.cOMP1690RestaurantsBindingSource1.DataSource = this.ts348DataSet2;
            // 
            // ts348DataSet2
            // 
            this.ts348DataSet2.DataSetName = "ts348DataSet2";
            this.ts348DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ts348DataSet1
            // 
            this.ts348DataSet1.DataSetName = "ts348DataSet";
            this.ts348DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMP1690_RestaurantsTableAdapter2
            // 
            this.cOMP1690_RestaurantsTableAdapter2.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(534, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1690RestaurantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMP1690RestaurantsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts348DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ts348DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.DataGridView dataGridView1;
        //private ts348DataSet ts348DataSet;
        //private System.Windows.Forms.BindingSource cOMP1690RestaurantsBindingSource;
        //private ts348DataSetTableAdapters.COMP1690_RestaurantsTableAdapter cOMP1690_RestaurantsTableAdapter;
        //private System.Windows.Forms.TextBox aName;
        //private System.Windows.Forms.TextBox aPost;
        //private System.Windows.Forms.TextBox aType;
        //private System.Windows.Forms.TextBox aAddress;
        //private System.Windows.Forms.TextBox aEmail;
        //private System.Windows.Forms.TextBox PriceBox;
        //private System.Windows.Forms.TextBox ADbox;
        //private System.Windows.Forms.Button Add;
        //private System.Data.SqlClient.SqlConnection sqlConnection1;
        //private System.Windows.Forms.TextBox SearchBox;
        //private System.Windows.Forms.Button Search;
        //private System.Windows.Forms.Button EditButton;
      

        //private System.Windows.Forms.TextBox eName;
       
        //private System.Windows.Forms.TextBox ePost;
        //private System.Windows.Forms.TextBox eType;
        //private System.Windows.Forms.TextBox eAddress;
        //private System.Windows.Forms.TextBox eEmail;
        //private System.Windows.Forms.TextBox textBox12;
        //private System.Windows.Forms.TextBox eAD;
        //private System.Windows.Forms.RadioButton aAdType2;
        //private System.Windows.Forms.RadioButton aAdType1;
        //private Component2.Component2 CheckComp;
        //private System.Windows.Forms.TextBox Websitebox;
        //private System.Windows.Forms.Button Upload;
        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn RestaurantID;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn RestType;
       
        private ClassLibrary1.PriceCheck PriceC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox aName;
        private System.Windows.Forms.TextBox aType;
        private System.Windows.Forms.TextBox aPost;
        private System.Windows.Forms.TextBox ADbox;
        private System.Windows.Forms.TextBox aEmail;
        private System.Windows.Forms.TextBox aAddress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Upload;
        private ts348DataSetTableAdapters.COMP1690_RestaurantsTableAdapter comP1690_RestaurantsTableAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.BindingSource cOMP1690RestaurantsBindingSource;
        private ts348DataSet1TableAdapters.COMP1690_RestaurantsTableAdapter cOMP1690_RestaurantsTableAdapter;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private ClassLibrary1.PriceCheck Ecomp;
        private System.Windows.Forms.TextBox eAD;
        private System.Windows.Forms.TextBox eEmail;
        private System.Windows.Forms.TextBox eAddress;
        private System.Windows.Forms.TextBox eType;
        private System.Windows.Forms.TextBox ePost;
        private System.Windows.Forms.TextBox eName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ts348DataSet ts348DataSet1;
        private ts348DataSet2 ts348DataSet2;
        private System.Windows.Forms.BindingSource cOMP1690RestaurantsBindingSource1;
        private ts348DataSet2TableAdapters.COMP1690_RestaurantsTableAdapter cOMP1690_RestaurantsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn restaurantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Search;
   
    }
}

