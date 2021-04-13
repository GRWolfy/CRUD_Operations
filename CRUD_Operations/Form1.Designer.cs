
namespace CRUD_Operations
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
         this.button1 = new System.Windows.Forms.Button();
         this.txtStudentName = new System.Windows.Forms.TextBox();
         this.StudentRecordDataGridView = new System.Windows.Forms.DataGridView();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.labelStudentName = new System.Windows.Forms.Label();
         this.labelRollNumber = new System.Windows.Forms.Label();
         this.labelAddress = new System.Windows.Forms.Label();
         this.txtMobileNumber = new System.Windows.Forms.TextBox();
         this.txtFatherName = new System.Windows.Forms.TextBox();
         this.txtAddress = new System.Windows.Forms.TextBox();
         this.txtRollNumber = new System.Windows.Forms.TextBox();
         this.labelFatherName = new System.Windows.Forms.Label();
         this.labelMobileNumber = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(38, 177);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(99, 34);
         this.button1.TabIndex = 0;
         this.button1.Text = "Insert";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // txtStudentName
         // 
         this.txtStudentName.Location = new System.Drawing.Point(135, 32);
         this.txtStudentName.Name = "txtStudentName";
         this.txtStudentName.Size = new System.Drawing.Size(100, 20);
         this.txtStudentName.TabIndex = 2;
         // 
         // StudentRecordDataGridView
         // 
         this.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.StudentRecordDataGridView.Location = new System.Drawing.Point(64, 217);
         this.StudentRecordDataGridView.Name = "StudentRecordDataGridView";
         this.StudentRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.StudentRecordDataGridView.Size = new System.Drawing.Size(458, 150);
         this.StudentRecordDataGridView.TabIndex = 3;
         this.StudentRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellClick);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(170, 177);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(99, 34);
         this.button2.TabIndex = 4;
         this.button2.Text = "Update";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(311, 177);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(99, 34);
         this.button3.TabIndex = 5;
         this.button3.Text = "Delete";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(439, 177);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(99, 34);
         this.button4.TabIndex = 6;
         this.button4.Text = "Reset";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // labelStudentName
         // 
         this.labelStudentName.AutoSize = true;
         this.labelStudentName.Location = new System.Drawing.Point(81, 32);
         this.labelStudentName.Name = "labelStudentName";
         this.labelStudentName.Size = new System.Drawing.Size(48, 13);
         this.labelStudentName.TabIndex = 1;
         this.labelStudentName.Text = "S.Name:";
         // 
         // labelRollNumber
         // 
         this.labelRollNumber.AutoSize = true;
         this.labelRollNumber.Location = new System.Drawing.Point(81, 79);
         this.labelRollNumber.Name = "labelRollNumber";
         this.labelRollNumber.Size = new System.Drawing.Size(45, 13);
         this.labelRollNumber.TabIndex = 7;
         this.labelRollNumber.Text = "Roll No.";
         // 
         // labelAddress
         // 
         this.labelAddress.AutoSize = true;
         this.labelAddress.Location = new System.Drawing.Point(81, 126);
         this.labelAddress.Name = "labelAddress";
         this.labelAddress.Size = new System.Drawing.Size(48, 13);
         this.labelAddress.TabIndex = 8;
         this.labelAddress.Text = "Address:";
         // 
         // txtMobileNumber
         // 
         this.txtMobileNumber.Location = new System.Drawing.Point(379, 79);
         this.txtMobileNumber.Name = "txtMobileNumber";
         this.txtMobileNumber.Size = new System.Drawing.Size(100, 20);
         this.txtMobileNumber.TabIndex = 9;
         // 
         // txtFatherName
         // 
         this.txtFatherName.Location = new System.Drawing.Point(379, 32);
         this.txtFatherName.Name = "txtFatherName";
         this.txtFatherName.Size = new System.Drawing.Size(100, 20);
         this.txtFatherName.TabIndex = 10;
         // 
         // txtAddress
         // 
         this.txtAddress.Location = new System.Drawing.Point(135, 119);
         this.txtAddress.Name = "txtAddress";
         this.txtAddress.Size = new System.Drawing.Size(100, 20);
         this.txtAddress.TabIndex = 11;
         // 
         // txtRollNumber
         // 
         this.txtRollNumber.Location = new System.Drawing.Point(135, 79);
         this.txtRollNumber.Name = "txtRollNumber";
         this.txtRollNumber.Size = new System.Drawing.Size(100, 20);
         this.txtRollNumber.TabIndex = 12;
         // 
         // labelFatherName
         // 
         this.labelFatherName.AutoSize = true;
         this.labelFatherName.Location = new System.Drawing.Point(316, 32);
         this.labelFatherName.Name = "labelFatherName";
         this.labelFatherName.Size = new System.Drawing.Size(50, 13);
         this.labelFatherName.TabIndex = 13;
         this.labelFatherName.Text = "F. Name:";
         // 
         // labelMobileNumber
         // 
         this.labelMobileNumber.AutoSize = true;
         this.labelMobileNumber.Location = new System.Drawing.Point(316, 79);
         this.labelMobileNumber.Name = "labelMobileNumber";
         this.labelMobileNumber.Size = new System.Drawing.Size(41, 13);
         this.labelMobileNumber.TabIndex = 14;
         this.labelMobileNumber.Text = "Mobile:";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.ActiveCaption;
         this.ClientSize = new System.Drawing.Size(569, 379);
         this.Controls.Add(this.labelMobileNumber);
         this.Controls.Add(this.labelFatherName);
         this.Controls.Add(this.txtRollNumber);
         this.Controls.Add(this.txtAddress);
         this.Controls.Add(this.txtFatherName);
         this.Controls.Add(this.txtMobileNumber);
         this.Controls.Add(this.labelAddress);
         this.Controls.Add(this.labelRollNumber);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.StudentRecordDataGridView);
         this.Controls.Add(this.txtStudentName);
         this.Controls.Add(this.labelStudentName);
         this.Controls.Add(this.button1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "Form1";
         this.RightToLeftLayout = true;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Student Information";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox txtStudentName;
      private System.Windows.Forms.DataGridView StudentRecordDataGridView;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Label labelStudentName;
      private System.Windows.Forms.Label labelRollNumber;
      private System.Windows.Forms.Label labelAddress;
      private System.Windows.Forms.TextBox txtMobileNumber;
      private System.Windows.Forms.TextBox txtFatherName;
      private System.Windows.Forms.TextBox txtAddress;
      private System.Windows.Forms.TextBox txtRollNumber;
      private System.Windows.Forms.Label labelFatherName;
      private System.Windows.Forms.Label labelMobileNumber;
   }
}

