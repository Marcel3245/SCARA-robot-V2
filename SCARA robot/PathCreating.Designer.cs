namespace SCARA_robot
{
    partial class PathCreating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PathCreating));
            this.TimerPathCreator = new System.Windows.Forms.Timer(this.components);
            this.treeViewPCPath = new System.Windows.Forms.TreeView();
            this.btnPCDelete = new System.Windows.Forms.Button();
            this.btnPCClear = new System.Windows.Forms.Button();
            this.btnPCRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPCSave = new System.Windows.Forms.Button();
            this.btnPCLoad = new System.Windows.Forms.Button();
            this.btnNodeUp = new System.Windows.Forms.Button();
            this.btnNodeDown = new System.Windows.Forms.Button();
            this.btnPCAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerPathCreator
            // 
            this.TimerPathCreator.Interval = 500;
            this.TimerPathCreator.Tick += new System.EventHandler(this.TimerPathCreator_Tick);
            // 
            // treeViewPCPath
            // 
            this.treeViewPCPath.Location = new System.Drawing.Point(6, 22);
            this.treeViewPCPath.Name = "treeViewPCPath";
            this.treeViewPCPath.Size = new System.Drawing.Size(403, 403);
            this.treeViewPCPath.TabIndex = 0;
            // 
            // btnPCDelete
            // 
            this.btnPCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPCDelete.Location = new System.Drawing.Point(16, 221);
            this.btnPCDelete.Name = "btnPCDelete";
            this.btnPCDelete.Size = new System.Drawing.Size(80, 62);
            this.btnPCDelete.TabIndex = 2;
            this.btnPCDelete.Text = "Delete";
            this.btnPCDelete.UseVisualStyleBackColor = true;
            this.btnPCDelete.Click += new System.EventHandler(this.btnPCDelete_Click);
            // 
            // btnPCClear
            // 
            this.btnPCClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPCClear.Location = new System.Drawing.Point(102, 221);
            this.btnPCClear.Name = "btnPCClear";
            this.btnPCClear.Size = new System.Drawing.Size(71, 62);
            this.btnPCClear.TabIndex = 4;
            this.btnPCClear.Text = "Clear";
            this.btnPCClear.UseVisualStyleBackColor = true;
            this.btnPCClear.Click += new System.EventHandler(this.btnPCClear_Click);
            // 
            // btnPCRun
            // 
            this.btnPCRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPCRun.Location = new System.Drawing.Point(16, 153);
            this.btnPCRun.Name = "btnPCRun";
            this.btnPCRun.Size = new System.Drawing.Size(157, 62);
            this.btnPCRun.TabIndex = 5;
            this.btnPCRun.Text = "Run";
            this.btnPCRun.UseVisualStyleBackColor = true;
            this.btnPCRun.Click += new System.EventHandler(this.btnPCRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeViewPCPath);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 430);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPCSave);
            this.groupBox2.Controls.Add(this.btnPCLoad);
            this.groupBox2.Controls.Add(this.btnPCClear);
            this.groupBox2.Controls.Add(this.btnNodeUp);
            this.groupBox2.Controls.Add(this.btnNodeDown);
            this.groupBox2.Controls.Add(this.btnPCAdd);
            this.groupBox2.Controls.Add(this.btnPCDelete);
            this.groupBox2.Controls.Add(this.btnPCRun);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(444, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 430);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Buttons";
            // 
            // btnPCSave
            // 
            this.btnPCSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPCSave.Location = new System.Drawing.Point(16, 365);
            this.btnPCSave.Name = "btnPCSave";
            this.btnPCSave.Size = new System.Drawing.Size(157, 59);
            this.btnPCSave.TabIndex = 9;
            this.btnPCSave.Text = "Save";
            this.btnPCSave.UseVisualStyleBackColor = true;
            this.btnPCSave.Click += new System.EventHandler(this.btnPCSave_Click);
            // 
            // btnPCLoad
            // 
            this.btnPCLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPCLoad.Location = new System.Drawing.Point(16, 299);
            this.btnPCLoad.Name = "btnPCLoad";
            this.btnPCLoad.Size = new System.Drawing.Size(157, 59);
            this.btnPCLoad.TabIndex = 8;
            this.btnPCLoad.Text = "Load";
            this.btnPCLoad.UseVisualStyleBackColor = true;
            this.btnPCLoad.Click += new System.EventHandler(this.btnPCLoad_Click);
            // 
            // btnNodeUp
            // 
            this.btnNodeUp.Image = ((System.Drawing.Image)(resources.GetObject("btnNodeUp.Image")));
            this.btnNodeUp.Location = new System.Drawing.Point(96, 30);
            this.btnNodeUp.Name = "btnNodeUp";
            this.btnNodeUp.Size = new System.Drawing.Size(58, 49);
            this.btnNodeUp.TabIndex = 7;
            this.btnNodeUp.UseVisualStyleBackColor = true;
            this.btnNodeUp.Click += new System.EventHandler(this.btnNodeUp_Click);
            // 
            // btnNodeDown
            // 
            this.btnNodeDown.Image = ((System.Drawing.Image)(resources.GetObject("btnNodeDown.Image")));
            this.btnNodeDown.Location = new System.Drawing.Point(32, 30);
            this.btnNodeDown.Name = "btnNodeDown";
            this.btnNodeDown.Size = new System.Drawing.Size(58, 49);
            this.btnNodeDown.TabIndex = 6;
            this.btnNodeDown.UseVisualStyleBackColor = true;
            this.btnNodeDown.Click += new System.EventHandler(this.btnNodeDown_Click);
            // 
            // btnPCAdd
            // 
            this.btnPCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPCAdd.Location = new System.Drawing.Point(16, 85);
            this.btnPCAdd.Name = "btnPCAdd";
            this.btnPCAdd.Size = new System.Drawing.Size(157, 62);
            this.btnPCAdd.TabIndex = 1;
            this.btnPCAdd.TabStop = false;
            this.btnPCAdd.Text = "Add";
            this.btnPCAdd.UseVisualStyleBackColor = true;
            this.btnPCAdd.Click += new System.EventHandler(this.btnPCAdd_Click);
            // 
            // PathCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PathCreating";
            this.Text = "Path Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerPathCreator;
        private System.Windows.Forms.TreeView treeViewPCPath;
        private System.Windows.Forms.Button btnPCDelete;
        private System.Windows.Forms.Button btnPCClear;
        private System.Windows.Forms.Button btnPCRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPCAdd;
        private System.Windows.Forms.Button btnNodeUp;
        private System.Windows.Forms.Button btnNodeDown;
        private System.Windows.Forms.Button btnPCSave;
        private System.Windows.Forms.Button btnPCLoad;
    }
}