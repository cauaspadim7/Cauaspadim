using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjetoWeb01.Dados;
using ProjetoWeb01.Classes.Entidades;

namespace AplicativoDesktop01
{
    public partial class TelaAdmin : Form
    {
        private const string urlApiadmin = "http://localhost:5000/api/usuarios/admin";
        public TelaAdmin()
        {
            InitializeComponent();
            CarregarAlunos();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarregarAlunos()
        {
            try
            {
                using var ctx = new AlunoContext();

                var lista = ctx.Alunos
                    .Select(a => new
                    {
                        a.Id,
                        a.RA,
                        a.StatusWIFI,
                        a.StatusAction,
                        a.CursoID,
                        TipoRegra = (int)a.Regra,
                        a.Nome,
                        a.Email,
                        a.Senha,
                        Regra = a.Regra.ToString()
                    })
                    .ToList();

                var dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ReadOnly = true,
                    AutoGenerateColumns = true,
                    DataSource = lista
                };

                // Adiciona o DataGridView ao formulário
                this.Controls.Add(dgv);
                dgv.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
