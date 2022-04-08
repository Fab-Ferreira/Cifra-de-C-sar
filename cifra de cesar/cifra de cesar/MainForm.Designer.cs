/*
 * Created by SharpDevelop.
 * User: rm20212930048
 * Date: 07/04/2022
 * Time: 11:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cifra_de_cesar
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button translate;
		private System.Windows.Forms.Label traduzido;
		private System.Windows.Forms.TextBox word;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.translate = new System.Windows.Forms.Button();
			this.traduzido = new System.Windows.Forms.Label();
			this.word = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// translate
			// 
			this.translate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.translate.Location = new System.Drawing.Point(137, 156);
			this.translate.Name = "translate";
			this.translate.Size = new System.Drawing.Size(104, 26);
			this.translate.TabIndex = 1;
			this.translate.Text = "Traduzir";
			this.translate.UseVisualStyleBackColor = true;
			this.translate.Click += new System.EventHandler(this.TranslateClick);
			// 
			// traduzido
			// 
			this.traduzido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.traduzido.Location = new System.Drawing.Point(56, 219);
			this.traduzido.Name = "traduzido";
			this.traduzido.Size = new System.Drawing.Size(263, 23);
			this.traduzido.TabIndex = 2;
			this.traduzido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// word
			// 
			this.word.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.word.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.word.Location = new System.Drawing.Point(99, 91);
			this.word.Name = "word";
			this.word.Size = new System.Drawing.Size(184, 26);
			this.word.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(271, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "CIFRA DE CÉSAR";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 274);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.word);
			this.Controls.Add(this.traduzido);
			this.Controls.Add(this.translate);
			this.Name = "MainForm";
			this.Text = "cifra de cesar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
