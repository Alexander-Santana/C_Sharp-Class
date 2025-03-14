namespace ShoppingList
{
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
            lblItemName = new Label();
            lblStore = new Label();
            lblPrice = new Label();
            txtItemName = new TextBox();
            txtStore = new TextBox();
            txtPrice = new TextBox();
            btnAddItem = new Button();
            btnDisplayList = new Button();
            btnClear = new Button();
            btnExit = new Button();
            listBoxItems = new ListBox();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(60, 281);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(83, 20);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name";
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(99, 331);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(44, 20);
            lblStore.TabIndex = 1;
            lblStore.Text = "Store";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(102, 382);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(181, 280);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(125, 27);
            txtItemName.TabIndex = 3;
            // 
            // txtStore
            // 
            txtStore.Location = new Point(181, 331);
            txtStore.Name = "txtStore";
            txtStore.Size = new Size(125, 27);
            txtStore.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(181, 382);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(358, 278);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 29);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDisplayList
            // 
            btnDisplayList.Location = new Point(358, 331);
            btnDisplayList.Name = "btnDisplayList";
            btnDisplayList.Size = new Size(94, 29);
            btnDisplayList.TabIndex = 7;
            btnDisplayList.Text = "Display List";
            btnDisplayList.UseVisualStyleBackColor = true;
            btnDisplayList.Click += btnDisplayList_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(358, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(672, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listBoxItems
            // 
            listBoxItems.FormattingEnabled = true;
            listBoxItems.Location = new Point(35, 30);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(731, 204);
            listBoxItems.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxItems);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDisplayList);
            Controls.Add(btnAddItem);
            Controls.Add(txtPrice);
            Controls.Add(txtStore);
            Controls.Add(txtItemName);
            Controls.Add(lblPrice);
            Controls.Add(lblStore);
            Controls.Add(lblItemName);
            Name = "Form1";
            Text = "Shopping List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblStore;
        private Label lblPrice;
        private TextBox txtItemName;
        private TextBox txtStore;
        private TextBox txtPrice;
        private Button btnAddItem;
        private Button btnDisplayList;
        private Button btnClear;
        private Button btnExit;
        private ListBox listBoxItems;
    }
}
