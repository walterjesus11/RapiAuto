namespace Win.RapiAuto
{
    partial class formVehiculos
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
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label cilindrajeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label kilometrajeLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVehiculos));
            this.listaVehiculosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaVehiculosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.añoTextBox = new System.Windows.Forms.TextBox();
            this.cilindrajeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.kilometrajeTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.btAgregarFoto = new System.Windows.Forms.Button();
            this.btRemoverFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            activoLabel = new System.Windows.Forms.Label();
            añoLabel = new System.Windows.Forms.Label();
            cilindrajeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            kilometrajeLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaVehiculosBindingNavigator)).BeginInit();
            this.listaVehiculosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(12, 229);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(12, 123);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(29, 13);
            añoLabel.TabIndex = 3;
            añoLabel.Text = "Año:";
            // 
            // cilindrajeLabel
            // 
            cilindrajeLabel.AutoSize = true;
            cilindrajeLabel.Location = new System.Drawing.Point(12, 201);
            cilindrajeLabel.Name = "cilindrajeLabel";
            cilindrajeLabel.Size = new System.Drawing.Size(52, 13);
            cilindrajeLabel.TabIndex = 5;
            cilindrajeLabel.Text = "Cilindraje:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 45);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // kilometrajeLabel
            // 
            kilometrajeLabel.AutoSize = true;
            kilometrajeLabel.Location = new System.Drawing.Point(12, 175);
            kilometrajeLabel.Name = "kilometrajeLabel";
            kilometrajeLabel.Size = new System.Drawing.Size(61, 13);
            kilometrajeLabel.TabIndex = 9;
            kilometrajeLabel.Text = "Kilometraje:";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(12, 71);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 11;
            marcaLabel.Text = "Marca:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(12, 97);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 13;
            modeloLabel.Text = "Modelo:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(12, 149);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 15;
            precioLabel.Text = "Precio:";
            // 
            // listaVehiculosBindingNavigator
            // 
            this.listaVehiculosBindingNavigator.AddNewItem = null;
            this.listaVehiculosBindingNavigator.BindingSource = this.listaVehiculosBindingSource;
            this.listaVehiculosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaVehiculosBindingNavigator.DeleteItem = null;
            this.listaVehiculosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaVehiculosBindingNavigatorSaveItem,
            this.Cancelar});
            this.listaVehiculosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaVehiculosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaVehiculosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaVehiculosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaVehiculosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaVehiculosBindingNavigator.Name = "listaVehiculosBindingNavigator";
            this.listaVehiculosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaVehiculosBindingNavigator.Size = new System.Drawing.Size(557, 25);
            this.listaVehiculosBindingNavigator.TabIndex = 0;
            this.listaVehiculosBindingNavigator.Text = "bindingNavigator1";
            this.listaVehiculosBindingNavigator.RefreshItems += new System.EventHandler(this.listaVehiculosBindingNavigator_RefreshItems);
            // 
            // listaVehiculosBindingSource
            // 
            this.listaVehiculosBindingSource.DataSource = typeof(BL.RapiAuto.Vehiculo);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaVehiculosBindingNavigatorSaveItem
            // 
            this.listaVehiculosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaVehiculosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaVehiculosBindingNavigatorSaveItem.Image")));
            this.listaVehiculosBindingNavigatorSaveItem.Name = "listaVehiculosBindingNavigatorSaveItem";
            this.listaVehiculosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaVehiculosBindingNavigatorSaveItem.Text = "Save Data";
            this.listaVehiculosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaVehiculosBindingNavigatorSaveItem_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Cancelar.Image")));
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(57, 22);
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaVehiculosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(79, 224);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // añoTextBox
            // 
            this.añoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Año", true));
            this.añoTextBox.Location = new System.Drawing.Point(79, 120);
            this.añoTextBox.Name = "añoTextBox";
            this.añoTextBox.Size = new System.Drawing.Size(184, 20);
            this.añoTextBox.TabIndex = 4;
            // 
            // cilindrajeTextBox
            // 
            this.cilindrajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Cilindraje", true));
            this.cilindrajeTextBox.Location = new System.Drawing.Point(79, 198);
            this.cilindrajeTextBox.Name = "cilindrajeTextBox";
            this.cilindrajeTextBox.Size = new System.Drawing.Size(184, 20);
            this.cilindrajeTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(79, 42);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(184, 20);
            this.idTextBox.TabIndex = 8;
            // 
            // kilometrajeTextBox
            // 
            this.kilometrajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Kilometraje", true));
            this.kilometrajeTextBox.Location = new System.Drawing.Point(79, 172);
            this.kilometrajeTextBox.Name = "kilometrajeTextBox";
            this.kilometrajeTextBox.Size = new System.Drawing.Size(184, 20);
            this.kilometrajeTextBox.TabIndex = 10;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(79, 68);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(184, 20);
            this.marcaTextBox.TabIndex = 12;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(79, 94);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(184, 20);
            this.modeloTextBox.TabIndex = 14;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaVehiculosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(79, 146);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(184, 20);
            this.precioTextBox.TabIndex = 16;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.Color.Silver;
            this.fotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaVehiculosBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(313, 42);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(186, 134);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 18;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // btAgregarFoto
            // 
            this.btAgregarFoto.Location = new System.Drawing.Point(313, 182);
            this.btAgregarFoto.Name = "btAgregarFoto";
            this.btAgregarFoto.Size = new System.Drawing.Size(85, 23);
            this.btAgregarFoto.TabIndex = 19;
            this.btAgregarFoto.Text = "Agregar Foto";
            this.btAgregarFoto.UseVisualStyleBackColor = true;
            this.btAgregarFoto.Click += new System.EventHandler(this.btAgregarFoto_Click);
            // 
            // btRemoverFoto
            // 
            this.btRemoverFoto.Location = new System.Drawing.Point(414, 182);
            this.btRemoverFoto.Name = "btRemoverFoto";
            this.btRemoverFoto.Size = new System.Drawing.Size(85, 23);
            this.btRemoverFoto.TabIndex = 20;
            this.btRemoverFoto.Text = "Remover Foto";
            this.btRemoverFoto.UseVisualStyleBackColor = true;
            this.btRemoverFoto.Click += new System.EventHandler(this.btRemoverFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg,png|*.jpg;*.png";
            // 
            // formVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 269);
            this.Controls.Add(this.btRemoverFoto);
            this.Controls.Add(this.btAgregarFoto);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(añoLabel);
            this.Controls.Add(this.añoTextBox);
            this.Controls.Add(cilindrajeLabel);
            this.Controls.Add(this.cilindrajeTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(kilometrajeLabel);
            this.Controls.Add(this.kilometrajeTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaVehiculosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formVehiculos";
            this.Text = "Vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.listaVehiculosBindingNavigator)).EndInit();
            this.listaVehiculosBindingNavigator.ResumeLayout(false);
            this.listaVehiculosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaVehiculosBindingSource;
        private System.Windows.Forms.BindingNavigator listaVehiculosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaVehiculosBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox añoTextBox;
        private System.Windows.Forms.TextBox cilindrajeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox kilometrajeTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ToolStripButton Cancelar;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button btAgregarFoto;
        private System.Windows.Forms.Button btRemoverFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}