namespace CapaPresentacion
{
    partial class Clientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanelGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.radioButtonEmpresas = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonas = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxBuscarNombre = new System.Windows.Forms.TextBox();
            this.buttonRefrescar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPaginacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.labelPagina = new System.Windows.Forms.Label();
            this.labelMensajes = new System.Windows.Forms.Label();
            this.tableLayoutPanelGeneral.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            this.tableLayoutPanelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelPaginacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGeneral
            // 
            this.tableLayoutPanelGeneral.ColumnCount = 1;
            this.tableLayoutPanelGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelGeneral.Controls.Add(this.dataGridViewClientes, 0, 1);
            this.tableLayoutPanelGeneral.Controls.Add(this.tableLayoutPanelBottom, 0, 2);
            this.tableLayoutPanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelGeneral.Name = "tableLayoutPanelGeneral";
            this.tableLayoutPanelGeneral.RowCount = 3;
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanelGeneral.Size = new System.Drawing.Size(848, 353);
            this.tableLayoutPanelGeneral.TabIndex = 0;
            this.tableLayoutPanelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelGeneral_Paint);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 6;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 324F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTop.Controls.Add(this.labelTitulo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonAgregar, 5, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonEliminar, 4, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonEditar, 3, 0);
            this.tableLayoutPanelTop.Controls.Add(this.groupBoxBuscar, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(842, 89);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Candara", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitulo.Location = new System.Drawing.Point(0, 8);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(278, 73);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "CLIENTES";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAgregar.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Image = global::CapaPresentacion.Properties.Resources.agregar;
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAgregar.Location = new System.Drawing.Point(775, 8);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(64, 78);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEliminar.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(705, 8);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(64, 78);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditar.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEditar.Font = new System.Drawing.Font("Candara", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(635, 8);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(64, 78);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.radioButtonEmpresas);
            this.groupBoxBuscar.Controls.Add(this.radioButtonPersonas);
            this.groupBoxBuscar.Controls.Add(this.tableLayoutPanelBuscar);
            this.groupBoxBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBuscar.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxBuscar.Location = new System.Drawing.Point(311, 1);
            this.groupBoxBuscar.Margin = new System.Windows.Forms.Padding(3, 1, 3, 4);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(318, 84);
            this.groupBoxBuscar.TabIndex = 4;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar Cliente";
            // 
            // radioButtonEmpresas
            // 
            this.radioButtonEmpresas.AutoSize = true;
            this.radioButtonEmpresas.Checked = true;
            this.radioButtonEmpresas.Location = new System.Drawing.Point(7, 56);
            this.radioButtonEmpresas.Name = "radioButtonEmpresas";
            this.radioButtonEmpresas.Size = new System.Drawing.Size(84, 21);
            this.radioButtonEmpresas.TabIndex = 2;
            this.radioButtonEmpresas.TabStop = true;
            this.radioButtonEmpresas.Text = "Empresas";
            this.radioButtonEmpresas.UseVisualStyleBackColor = true;
            // 
            // radioButtonPersonas
            // 
            this.radioButtonPersonas.AutoSize = true;
            this.radioButtonPersonas.Location = new System.Drawing.Point(7, 28);
            this.radioButtonPersonas.Name = "radioButtonPersonas";
            this.radioButtonPersonas.Size = new System.Drawing.Size(81, 21);
            this.radioButtonPersonas.TabIndex = 1;
            this.radioButtonPersonas.Text = "Personas";
            this.radioButtonPersonas.UseVisualStyleBackColor = true;
            this.radioButtonPersonas.CheckedChanged += new System.EventHandler(this.radioButtonPersonas_CheckedChanged);
            // 
            // tableLayoutPanelBuscar
            // 
            this.tableLayoutPanelBuscar.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBuscar.ColumnCount = 2;
            this.tableLayoutPanelBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.12245F));
            this.tableLayoutPanelBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.87755F));
            this.tableLayoutPanelBuscar.Controls.Add(this.labelNombre, 0, 0);
            this.tableLayoutPanelBuscar.Controls.Add(this.textBoxBuscarNombre, 1, 0);
            this.tableLayoutPanelBuscar.Controls.Add(this.buttonRefrescar, 1, 1);
            this.tableLayoutPanelBuscar.Location = new System.Drawing.Point(106, 23);
            this.tableLayoutPanelBuscar.Name = "tableLayoutPanelBuscar";
            this.tableLayoutPanelBuscar.RowCount = 2;
            this.tableLayoutPanelBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBuscar.Size = new System.Drawing.Size(206, 54);
            this.tableLayoutPanelBuscar.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(3, 5);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(61, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxBuscarNombre
            // 
            this.textBoxBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarNombre.Location = new System.Drawing.Point(67, 3);
            this.textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            this.textBoxBuscarNombre.Size = new System.Drawing.Size(136, 22);
            this.textBoxBuscarNombre.TabIndex = 1;
            this.textBoxBuscarNombre.TextChanged += new System.EventHandler(this.textBoxBuscarNombre_TextChanged);
            // 
            // buttonRefrescar
            // 
            this.buttonRefrescar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefrescar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefrescar.Location = new System.Drawing.Point(66, 27);
            this.buttonRefrescar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buttonRefrescar.Name = "buttonRefrescar";
            this.buttonRefrescar.Size = new System.Drawing.Size(138, 27);
            this.buttonRefrescar.TabIndex = 3;
            this.buttonRefrescar.Text = "Refrescar";
            this.buttonRefrescar.UseVisualStyleBackColor = false;
            this.buttonRefrescar.Click += new System.EventHandler(this.buttonRefrescar_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewClientes.ColumnHeadersHeight = 50;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientes.EnableHeadersVisualStyles = false;
            this.dataGridViewClientes.Location = new System.Drawing.Point(13, 98);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(13, 3, 7, 3);
            this.dataGridViewClientes.MultiSelect = false;
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.RowTemplate.ReadOnly = true;
            this.dataGridViewClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.ShowCellErrors = false;
            this.dataGridViewClientes.ShowCellToolTips = false;
            this.dataGridViewClientes.ShowEditingIcon = false;
            this.dataGridViewClientes.ShowRowErrors = false;
            this.dataGridViewClientes.Size = new System.Drawing.Size(828, 208);
            this.dataGridViewClientes.TabIndex = 2;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.52239F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.47761F));
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanelPaginacion, 1, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.labelMensajes, 0, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(3, 312);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(842, 38);
            this.tableLayoutPanelBottom.TabIndex = 3;
            // 
            // tableLayoutPanelPaginacion
            // 
            this.tableLayoutPanelPaginacion.ColumnCount = 3;
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanelPaginacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPaginacion.Controls.Add(this.buttonSiguiente, 2, 0);
            this.tableLayoutPanelPaginacion.Controls.Add(this.buttonAnterior, 1, 0);
            this.tableLayoutPanelPaginacion.Controls.Add(this.labelPagina, 0, 0);
            this.tableLayoutPanelPaginacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPaginacion.Location = new System.Drawing.Point(470, 3);
            this.tableLayoutPanelPaginacion.Name = "tableLayoutPanelPaginacion";
            this.tableLayoutPanelPaginacion.RowCount = 1;
            this.tableLayoutPanelPaginacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaginacion.Size = new System.Drawing.Size(369, 32);
            this.tableLayoutPanelPaginacion.TabIndex = 2;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSiguiente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiguiente.Location = new System.Drawing.Point(272, 0);
            this.buttonSiguiente.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(97, 32);
            this.buttonSiguiente.TabIndex = 0;
            this.buttonSiguiente.Text = ">>";
            this.buttonSiguiente.UseVisualStyleBackColor = false;
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnterior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnterior.Location = new System.Drawing.Point(167, 0);
            this.buttonAnterior.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(95, 32);
            this.buttonAnterior.TabIndex = 1;
            this.buttonAnterior.Text = "<<";
            this.buttonAnterior.UseVisualStyleBackColor = false;
            // 
            // labelPagina
            // 
            this.labelPagina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPagina.AutoSize = true;
            this.labelPagina.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagina.Location = new System.Drawing.Point(64, 6);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(100, 19);
            this.labelPagina.TabIndex = 2;
            this.labelPagina.Text = "Página X de X";
            // 
            // labelMensajes
            // 
            this.labelMensajes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMensajes.AutoSize = true;
            this.labelMensajes.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajes.Location = new System.Drawing.Point(3, 9);
            this.labelMensajes.Name = "labelMensajes";
            this.labelMensajes.Size = new System.Drawing.Size(445, 19);
            this.labelMensajes.TabIndex = 3;
            this.labelMensajes.Text = "Bienvenido al Sistema de Gestión. Este será su Área de Mensajes";
            this.labelMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelGeneral);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(848, 353);
            this.tableLayoutPanelGeneral.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            this.tableLayoutPanelBuscar.ResumeLayout(false);
            this.tableLayoutPanelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelBottom.PerformLayout();
            this.tableLayoutPanelPaginacion.ResumeLayout(false);
            this.tableLayoutPanelPaginacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBuscar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxBuscarNombre;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaginacion;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Label labelMensajes;
        private System.Windows.Forms.Button buttonRefrescar;
        private System.Windows.Forms.RadioButton radioButtonEmpresas;
        private System.Windows.Forms.RadioButton radioButtonPersonas;
    }
}
