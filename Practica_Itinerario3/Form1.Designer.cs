namespace Practica_Itinerario3
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
         dGVPartidos = new DataGridView();
         btnVerPartidos = new Button();
         ((System.ComponentModel.ISupportInitialize)dGVPartidos).BeginInit();
         SuspendLayout();
         // 
         // dGVPartidos
         // 
         dGVPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dGVPartidos.Location = new Point(24, 12);
         dGVPartidos.Name = "dGVPartidos";
         dGVPartidos.RowHeadersWidth = 51;
         dGVPartidos.RowTemplate.Height = 29;
         dGVPartidos.Size = new Size(752, 350);
         dGVPartidos.TabIndex = 0;
         // 
         // btnVerPartidos
         // 
         btnVerPartidos.Location = new Point(310, 368);
         btnVerPartidos.Name = "btnVerPartidos";
         btnVerPartidos.Size = new Size(153, 57);
         btnVerPartidos.TabIndex = 1;
         btnVerPartidos.Text = "Ver partidos";
         btnVerPartidos.UseVisualStyleBackColor = true;
         btnVerPartidos.Click += btnVerPartidos_Click;
         // 
         // Form1
         // 
         AutoScaleDimensions = new SizeF(8F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(800, 450);
         Controls.Add(btnVerPartidos);
         Controls.Add(dGVPartidos);
         Name = "Form1";
         Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)dGVPartidos).EndInit();
         ResumeLayout(false);
      }

      #endregion

      private DataGridView dGVPartidos;
      private Button btnVerPartidos;
   }
}