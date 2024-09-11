namespace LunchOrder
{
    partial class frmLunchOrder
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
            grpMainCourse = new GroupBox();
            radMainThird = new RadioButton();
            radMainSecond = new RadioButton();
            radMainFirst = new RadioButton();
            grpAddOns = new GroupBox();
            chkAddOn3 = new CheckBox();
            chkAddOn2 = new CheckBox();
            chkAddOn1 = new CheckBox();
            grpOrderTotal = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOrderTotal = new TextBox();
            txtTax = new TextBox();
            txtSubtotal = new TextBox();
            btnPlaceOrder = new Button();
            btnReset = new Button();
            btnExit = new Button();
            grpMainCourse.SuspendLayout();
            grpAddOns.SuspendLayout();
            grpOrderTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpMainCourse
            // 
            grpMainCourse.Controls.Add(radMainThird);
            grpMainCourse.Controls.Add(radMainSecond);
            grpMainCourse.Controls.Add(radMainFirst);
            grpMainCourse.Location = new Point(10, 10);
            grpMainCourse.Name = "grpMainCourse";
            grpMainCourse.Size = new Size(250, 125);
            grpMainCourse.TabIndex = 0;
            grpMainCourse.TabStop = false;
            grpMainCourse.Text = "Main Course";
            // 
            // radMainThird
            // 
            radMainThird.AutoSize = true;
            radMainThird.Location = new Point(6, 86);
            radMainThird.Name = "radMainThird";
            radMainThird.Size = new Size(124, 24);
            radMainThird.TabIndex = 4;
            radMainThird.TabStop = true;
            radMainThird.Text = "Main Course 3";
            radMainThird.UseVisualStyleBackColor = true;
            radMainThird.CheckedChanged += RadMain_CheckChanged;
            // 
            // radMainSecond
            // 
            radMainSecond.AutoSize = true;
            radMainSecond.Location = new Point(6, 56);
            radMainSecond.Name = "radMainSecond";
            radMainSecond.Size = new Size(124, 24);
            radMainSecond.TabIndex = 3;
            radMainSecond.TabStop = true;
            radMainSecond.Text = "Main Course 2";
            radMainSecond.UseVisualStyleBackColor = true;
            radMainSecond.CheckedChanged += RadMain_CheckChanged;
            // 
            // radMainFirst
            // 
            radMainFirst.AutoSize = true;
            radMainFirst.Location = new Point(6, 26);
            radMainFirst.Name = "radMainFirst";
            radMainFirst.Size = new Size(124, 24);
            radMainFirst.TabIndex = 0;
            radMainFirst.TabStop = true;
            radMainFirst.Text = "Main Course 1";
            radMainFirst.UseVisualStyleBackColor = true;
            radMainFirst.CheckedChanged += RadMain_CheckChanged;
            // 
            // grpAddOns
            // 
            grpAddOns.Controls.Add(chkAddOn3);
            grpAddOns.Controls.Add(chkAddOn2);
            grpAddOns.Controls.Add(chkAddOn1);
            grpAddOns.Location = new Point(266, 10);
            grpAddOns.Name = "grpAddOns";
            grpAddOns.Size = new Size(250, 125);
            grpAddOns.TabIndex = 1;
            grpAddOns.TabStop = false;
            grpAddOns.Text = "Add-on items";
            // 
            // chkAddOn3
            // 
            chkAddOn3.AutoSize = true;
            chkAddOn3.Location = new Point(6, 86);
            chkAddOn3.Name = "chkAddOn3";
            chkAddOn3.Size = new Size(72, 24);
            chkAddOn3.TabIndex = 2;
            chkAddOn3.Text = "Side 3";
            chkAddOn3.UseVisualStyleBackColor = true;
            // 
            // chkAddOn2
            // 
            chkAddOn2.AutoSize = true;
            chkAddOn2.Location = new Point(6, 56);
            chkAddOn2.Name = "chkAddOn2";
            chkAddOn2.Size = new Size(72, 24);
            chkAddOn2.TabIndex = 1;
            chkAddOn2.Text = "Side 2";
            chkAddOn2.UseVisualStyleBackColor = true;
            // 
            // chkAddOn1
            // 
            chkAddOn1.AutoSize = true;
            chkAddOn1.Location = new Point(6, 26);
            chkAddOn1.Name = "chkAddOn1";
            chkAddOn1.Size = new Size(72, 24);
            chkAddOn1.TabIndex = 0;
            chkAddOn1.Text = "Side 1";
            chkAddOn1.UseVisualStyleBackColor = true;
            // 
            // grpOrderTotal
            // 
            grpOrderTotal.Controls.Add(label3);
            grpOrderTotal.Controls.Add(label2);
            grpOrderTotal.Controls.Add(label1);
            grpOrderTotal.Controls.Add(txtOrderTotal);
            grpOrderTotal.Controls.Add(txtTax);
            grpOrderTotal.Controls.Add(txtSubtotal);
            grpOrderTotal.Location = new Point(10, 141);
            grpOrderTotal.Name = "grpOrderTotal";
            grpOrderTotal.Size = new Size(250, 125);
            grpOrderTotal.TabIndex = 2;
            grpOrderTotal.TabStop = false;
            grpOrderTotal.Text = "Order Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 99);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Order Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Tax (5%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 33);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "Subtotal:";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Enabled = false;
            txtOrderTotal.Location = new Point(119, 92);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.Size = new Size(125, 27);
            txtOrderTotal.TabIndex = 2;
            // 
            // txtTax
            // 
            txtTax.Enabled = false;
            txtTax.Location = new Point(119, 59);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(125, 27);
            txtTax.TabIndex = 1;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new Point(119, 26);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(266, 163);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(94, 29);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "&Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(266, 198);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(422, 265);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmLunchOrder
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReset;
            ClientSize = new Size(524, 305);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnPlaceOrder);
            Controls.Add(grpOrderTotal);
            Controls.Add(grpAddOns);
            Controls.Add(grpMainCourse);
            Name = "frmLunchOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lunch Order";
            Load += frmLunchOrder_Load;
            grpMainCourse.ResumeLayout(false);
            grpMainCourse.PerformLayout();
            grpAddOns.ResumeLayout(false);
            grpAddOns.PerformLayout();
            grpOrderTotal.ResumeLayout(false);
            grpOrderTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpMainCourse;
        private GroupBox grpAddOns;
        private GroupBox grpOrderTotal;
        private RadioButton radMainThird;
        private RadioButton radMainSecond;
        private RadioButton radMainFirst;
        private Label label1;
        private TextBox txtOrderTotal;
        private TextBox txtTax;
        private TextBox txtSubtotal;
        private Label label3;
        private Label label2;
        private CheckBox chkAddOn3;
        private CheckBox chkAddOn2;
        private CheckBox chkAddOn1;
        private Button btnPlaceOrder;
        private Button btnReset;
        private Button btnExit;
    }
}
