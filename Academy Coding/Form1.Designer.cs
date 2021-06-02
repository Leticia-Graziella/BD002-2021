
using System;

namespace AcademyCoding
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
            this.btn_start = new System.Windows.Forms.Button();
            this.cb_autentificacaoTarget = new System.Windows.Forms.CheckBox();
            this.cb_autentificacaoSource = new System.Windows.Forms.CheckBox();
            this.lb_servdorSource = new System.Windows.Forms.Label();
            this.lb_dataBaseSource = new System.Windows.Forms.Label();
            this.lb_tabelaSource = new System.Windows.Forms.Label();
            this.lb_usuarioSource = new System.Windows.Forms.Label();
            this.lb_senhaSource = new System.Windows.Forms.Label();
            this.lb_servidorTarget = new System.Windows.Forms.Label();
            this.lb_dataBaseTarget = new System.Windows.Forms.Label();
            this.lb_tabelaTarget = new System.Windows.Forms.Label();
            this.lb_usuarioTarget = new System.Windows.Forms.Label();
            this.lb_senhaTarget = new System.Windows.Forms.Label();
            this.lb_servidor_Source = new System.Windows.Forms.Label();
            this.lb_servidor_Target = new System.Windows.Forms.Label();
            this.txt_servidorSource = new System.Windows.Forms.TextBox();
            this.txt_dataBaseSource = new System.Windows.Forms.TextBox();
            this.txt_tabelaSource = new System.Windows.Forms.TextBox();
            this.txt_usuarioSource = new System.Windows.Forms.TextBox();
            this.txt_senhaSource = new System.Windows.Forms.TextBox();
            this.txt_servidorTarget = new System.Windows.Forms.TextBox();
            this.txt_dataBaseTarget = new System.Windows.Forms.TextBox();
            this.txt_tabelaTarget = new System.Windows.Forms.TextBox();
            this.txt_usuarioTarget = new System.Windows.Forms.TextBox();
            this.txt_senhaTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(371, 363);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(90, 37);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Começar";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // cb_autentificacaoTarget
            // 
            this.cb_autentificacaoTarget.AutoSize = true;
            this.cb_autentificacaoTarget.Checked = true;
            this.cb_autentificacaoTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autentificacaoTarget.Location = new System.Drawing.Point(524, 296);
            this.cb_autentificacaoTarget.Name = "cb_autentificacaoTarget";
            this.cb_autentificacaoTarget.Size = new System.Drawing.Size(179, 19);
            this.cb_autentificacaoTarget.TabIndex = 1;
            this.cb_autentificacaoTarget.Text = "Autentificação pelo windows";
            this.cb_autentificacaoTarget.UseVisualStyleBackColor = true;
            this.cb_autentificacaoTarget.Click += new System.EventHandler(this.cb_autentificacaoTarget_Click);
            // 
            // cb_autentificacaoSource
            // 
            this.cb_autentificacaoSource.AutoSize = true;
            this.cb_autentificacaoSource.Checked = true;
            this.cb_autentificacaoSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autentificacaoSource.Location = new System.Drawing.Point(146, 296);
            this.cb_autentificacaoSource.Name = "cb_autentificacaoSource";
            this.cb_autentificacaoSource.Size = new System.Drawing.Size(179, 19);
            this.cb_autentificacaoSource.TabIndex = 2;
            this.cb_autentificacaoSource.Text = "Autentificação pelo windows";
            this.cb_autentificacaoSource.UseVisualStyleBackColor = true;
            this.cb_autentificacaoSource.Click += new System.EventHandler(this.cb_autentificacaoSource_Click_1);
            // 
            // lb_servdorSource
            // 
            this.lb_servdorSource.AutoSize = true;
            this.lb_servdorSource.Location = new System.Drawing.Point(114, 88);
            this.lb_servdorSource.Name = "lb_servdorSource";
            this.lb_servdorSource.Size = new System.Drawing.Size(50, 15);
            this.lb_servdorSource.TabIndex = 3;
            this.lb_servdorSource.Text = "Servidor";
            // 
            // lb_dataBaseSource
            // 
            this.lb_dataBaseSource.AutoSize = true;
            this.lb_dataBaseSource.Location = new System.Drawing.Point(109, 131);
            this.lb_dataBaseSource.Name = "lb_dataBaseSource";
            this.lb_dataBaseSource.Size = new System.Drawing.Size(55, 15);
            this.lb_dataBaseSource.TabIndex = 4;
            this.lb_dataBaseSource.Text = "DataBase";
            // 
            // lb_tabelaSource
            // 
            this.lb_tabelaSource.AutoSize = true;
            this.lb_tabelaSource.Location = new System.Drawing.Point(124, 172);
            this.lb_tabelaSource.Name = "lb_tabelaSource";
            this.lb_tabelaSource.Size = new System.Drawing.Size(40, 15);
            this.lb_tabelaSource.TabIndex = 5;
            this.lb_tabelaSource.Text = "Tabela";
            // 
            // lb_usuarioSource
            // 
            this.lb_usuarioSource.AutoSize = true;
            this.lb_usuarioSource.Enabled = false;
            this.lb_usuarioSource.Location = new System.Drawing.Point(117, 210);
            this.lb_usuarioSource.Name = "lb_usuarioSource";
            this.lb_usuarioSource.Size = new System.Drawing.Size(47, 15);
            this.lb_usuarioSource.TabIndex = 6;
            this.lb_usuarioSource.Text = "Usuário";
            // 
            // lb_senhaSource
            // 
            this.lb_senhaSource.AutoSize = true;
            this.lb_senhaSource.Enabled = false;
            this.lb_senhaSource.Location = new System.Drawing.Point(125, 252);
            this.lb_senhaSource.Name = "lb_senhaSource";
            this.lb_senhaSource.Size = new System.Drawing.Size(39, 15);
            this.lb_senhaSource.TabIndex = 7;
            this.lb_senhaSource.Text = "Senha";
            // 
            // lb_servidorTarget
            // 
            this.lb_servidorTarget.AutoSize = true;
            this.lb_servidorTarget.Location = new System.Drawing.Point(500, 88);
            this.lb_servidorTarget.Name = "lb_servidorTarget";
            this.lb_servidorTarget.Size = new System.Drawing.Size(50, 15);
            this.lb_servidorTarget.TabIndex = 8;
            this.lb_servidorTarget.Text = "Servidor";
            // 
            // lb_dataBaseTarget
            // 
            this.lb_dataBaseTarget.AutoSize = true;
            this.lb_dataBaseTarget.Location = new System.Drawing.Point(495, 131);
            this.lb_dataBaseTarget.Name = "lb_dataBaseTarget";
            this.lb_dataBaseTarget.Size = new System.Drawing.Size(55, 15);
            this.lb_dataBaseTarget.TabIndex = 9;
            this.lb_dataBaseTarget.Text = "DataBase";
            // 
            // lb_tabelaTarget
            // 
            this.lb_tabelaTarget.AutoSize = true;
            this.lb_tabelaTarget.Location = new System.Drawing.Point(510, 172);
            this.lb_tabelaTarget.Name = "lb_tabelaTarget";
            this.lb_tabelaTarget.Size = new System.Drawing.Size(40, 15);
            this.lb_tabelaTarget.TabIndex = 10;
            this.lb_tabelaTarget.Text = "Tabela";
            // 
            // lb_usuarioTarget
            // 
            this.lb_usuarioTarget.AutoSize = true;
            this.lb_usuarioTarget.Enabled = false;
            this.lb_usuarioTarget.Location = new System.Drawing.Point(503, 210);
            this.lb_usuarioTarget.Name = "lb_usuarioTarget";
            this.lb_usuarioTarget.Size = new System.Drawing.Size(47, 15);
            this.lb_usuarioTarget.TabIndex = 11;
            this.lb_usuarioTarget.Text = "Usuário";
            // 
            // lb_senhaTarget
            // 
            this.lb_senhaTarget.AutoSize = true;
            this.lb_senhaTarget.Enabled = false;
            this.lb_senhaTarget.Location = new System.Drawing.Point(511, 252);
            this.lb_senhaTarget.Name = "lb_senhaTarget";
            this.lb_senhaTarget.Size = new System.Drawing.Size(39, 15);
            this.lb_senhaTarget.TabIndex = 12;
            this.lb_senhaTarget.Text = "Senha";
            // 
            // lb_servidor_Source
            // 
            this.lb_servidor_Source.AutoSize = true;
            this.lb_servidor_Source.Location = new System.Drawing.Point(187, 44);
            this.lb_servidor_Source.Name = "lb_servidor_Source";
            this.lb_servidor_Source.Size = new System.Drawing.Size(89, 15);
            this.lb_servidor_Source.TabIndex = 13;
            this.lb_servidor_Source.Text = "Servidor Source";
            // 
            // lb_servidor_Target
            // 
            this.lb_servidor_Target.AutoSize = true;
            this.lb_servidor_Target.Location = new System.Drawing.Point(572, 44);
            this.lb_servidor_Target.Name = "lb_servidor_Target";
            this.lb_servidor_Target.Size = new System.Drawing.Size(85, 15);
            this.lb_servidor_Target.TabIndex = 14;
            this.lb_servidor_Target.Text = "Servidor Target";
            // 
            // txt_servidorSource
            // 
            this.txt_servidorSource.Location = new System.Drawing.Point(170, 85);
            this.txt_servidorSource.Name = "txt_servidorSource";
            this.txt_servidorSource.Size = new System.Drawing.Size(132, 23);
            this.txt_servidorSource.TabIndex = 15;
            this.txt_servidorSource.Text = ".\\SQLEXPRESS";
            // 
            // txt_dataBaseSource
            // 
            this.txt_dataBaseSource.Location = new System.Drawing.Point(170, 126);
            this.txt_dataBaseSource.Name = "txt_dataBaseSource";
            this.txt_dataBaseSource.Size = new System.Drawing.Size(132, 23);
            this.txt_dataBaseSource.TabIndex = 16;
            this.txt_dataBaseSource.Text = "Artistas";
            // 
            // txt_tabelaSource
            // 
            this.txt_tabelaSource.Location = new System.Drawing.Point(170, 164);
            this.txt_tabelaSource.Name = "txt_tabelaSource";
            this.txt_tabelaSource.Size = new System.Drawing.Size(132, 23);
            this.txt_tabelaSource.TabIndex = 17;
            this.txt_tabelaSource.Text = "Cantores_POP";
            // 
            // txt_usuarioSource
            // 
            this.txt_usuarioSource.Enabled = false;
            this.txt_usuarioSource.Location = new System.Drawing.Point(170, 205);
            this.txt_usuarioSource.Name = "txt_usuarioSource";
            this.txt_usuarioSource.Size = new System.Drawing.Size(132, 23);
            this.txt_usuarioSource.TabIndex = 18;
            this.txt_usuarioSource.TextChanged += new System.EventHandler(this.txt_usuarioSource_TextChanged);
            // 
            // txt_senhaSource
            // 
            this.txt_senhaSource.Enabled = false;
            this.txt_senhaSource.Location = new System.Drawing.Point(170, 244);
            this.txt_senhaSource.Name = "txt_senhaSource";
            this.txt_senhaSource.Size = new System.Drawing.Size(132, 23);
            this.txt_senhaSource.TabIndex = 19;
            this.txt_senhaSource.TextChanged += new System.EventHandler(this.txt_senhaSource_TextChanged);
            // 
            // txt_servidorTarget
            // 
            this.txt_servidorTarget.Location = new System.Drawing.Point(556, 85);
            this.txt_servidorTarget.Name = "txt_servidorTarget";
            this.txt_servidorTarget.Size = new System.Drawing.Size(147, 23);
            this.txt_servidorTarget.TabIndex = 20;
            this.txt_servidorTarget.Text = ".\\SQLEXPRESS";
            // 
            // txt_dataBaseTarget
            // 
            this.txt_dataBaseTarget.Location = new System.Drawing.Point(556, 128);
            this.txt_dataBaseTarget.Name = "txt_dataBaseTarget";
            this.txt_dataBaseTarget.Size = new System.Drawing.Size(147, 23);
            this.txt_dataBaseTarget.TabIndex = 21;
            this.txt_dataBaseTarget.Text = "Artistas";
            // 
            // txt_tabelaTarget
            // 
            this.txt_tabelaTarget.Location = new System.Drawing.Point(556, 164);
            this.txt_tabelaTarget.Name = "txt_tabelaTarget";
            this.txt_tabelaTarget.Size = new System.Drawing.Size(147, 23);
            this.txt_tabelaTarget.TabIndex = 22;
            this.txt_tabelaTarget.Text = "Cantore_POPBK";
            // 
            // txt_usuarioTarget
            // 
            this.txt_usuarioTarget.Enabled = false;
            this.txt_usuarioTarget.Location = new System.Drawing.Point(556, 205);
            this.txt_usuarioTarget.Name = "txt_usuarioTarget";
            this.txt_usuarioTarget.Size = new System.Drawing.Size(147, 23);
            this.txt_usuarioTarget.TabIndex = 23;
            // 
            // txt_senhaTarget
            // 
            this.txt_senhaTarget.Enabled = false;
            this.txt_senhaTarget.Location = new System.Drawing.Point(556, 244);
            this.txt_senhaTarget.Name = "txt_senhaTarget";
            this.txt_senhaTarget.Size = new System.Drawing.Size(147, 23);
            this.txt_senhaTarget.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.txt_senhaTarget);
            this.Controls.Add(this.txt_usuarioTarget);
            this.Controls.Add(this.txt_tabelaTarget);
            this.Controls.Add(this.txt_dataBaseTarget);
            this.Controls.Add(this.txt_servidorTarget);
            this.Controls.Add(this.txt_senhaSource);
            this.Controls.Add(this.txt_usuarioSource);
            this.Controls.Add(this.txt_tabelaSource);
            this.Controls.Add(this.txt_dataBaseSource);
            this.Controls.Add(this.txt_servidorSource);
            this.Controls.Add(this.lb_servidor_Target);
            this.Controls.Add(this.lb_servidor_Source);
            this.Controls.Add(this.lb_senhaTarget);
            this.Controls.Add(this.lb_usuarioTarget);
            this.Controls.Add(this.lb_tabelaTarget);
            this.Controls.Add(this.lb_dataBaseTarget);
            this.Controls.Add(this.lb_servidorTarget);
            this.Controls.Add(this.lb_senhaSource);
            this.Controls.Add(this.lb_usuarioSource);
            this.Controls.Add(this.lb_tabelaSource);
            this.Controls.Add(this.lb_dataBaseSource);
            this.Controls.Add(this.lb_servdorSource);
            this.Controls.Add(this.cb_autentificacaoSource);
            this.Controls.Add(this.cb_autentificacaoTarget);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.CheckBox cb_autentificacaoTarget;
        private System.Windows.Forms.CheckBox cb_autentificacaoSource;
        private System.Windows.Forms.Label lb_servdorSource;
        private System.Windows.Forms.Label lb_dataBaseSource;
        private System.Windows.Forms.Label lb_tabelaSource;
        private System.Windows.Forms.Label lb_usuarioSource;
        private System.Windows.Forms.Label lb_senhaSource;
        private System.Windows.Forms.Label lb_servidorTarget;
        private System.Windows.Forms.Label lb_dataBaseTarget;
        private System.Windows.Forms.Label lb_tabelaTarget;
        private System.Windows.Forms.Label lb_usuarioTarget;
        private System.Windows.Forms.Label lb_senhaTarget;
        private System.Windows.Forms.Label lb_servidor_Source;
        private System.Windows.Forms.Label lb_servidor_Target;
        private System.Windows.Forms.TextBox txt_servidorSource;
        private System.Windows.Forms.TextBox txt_dataBaseSource;
        private System.Windows.Forms.TextBox txt_tabelaSource;
        private System.Windows.Forms.TextBox txt_usuarioSource;
        private System.Windows.Forms.TextBox txt_senhaSource;
        private System.Windows.Forms.TextBox txt_servidorTarget;
        private System.Windows.Forms.TextBox txt_dataBaseTarget;
        private System.Windows.Forms.TextBox txt_tabelaTarget;
        private System.Windows.Forms.TextBox txt_usuarioTarget;
        private System.Windows.Forms.TextBox txt_senhaTarget;
        private EventHandler cb_autentificacaoSource_CheckedChanged;
        private EventHandler cb_autentificacaoSource_Click;
    }
}

