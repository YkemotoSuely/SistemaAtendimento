﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAtendimento.Controller;
using SistemaAtendimento.Model;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimento : Form
    {

        private AtendimentoController _atendimentoController;

        public FrmAtendimento()
        {
            InitializeComponent();
            _atendimentoController = new AtendimentoController(this);
        }


        private void btnPesquisarAtendimento_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsultaAtendimento = new FrmConsultaAtendimento();
            frmConsultaAtendimento.ShowDialog();
        }

        private void CarregarClientes()
        {
            var clientes = _atendimentoController.ListarClientes();

            cbxNomeCliente.DataSource = clientes;
            cbxNomeCliente.DisplayMember = "Nome";
            cbxNomeCliente.SelectedIndex = -1;
            cbxNomeCliente.ValueMember = "Id";

            //filtros no comboBox
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void FrmAtendimento_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarEtapas();
            CarregarSituacaoAtendimento();
        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoCliente.Clear();

            if (cbxNomeCliente.SelectedValue != null) 
            {
                txtCodigoCliente.Text = cbxNomeCliente.SelectedValue.ToString();
            }
        }

        private void CarregarEtapas() 
        {
            var etapas = _atendimentoController.ListarEtapas();
            cbxEtapaAtendimento.DataSource = etapas;    
            cbxEtapaAtendimento.DisplayMember = "Nome";
            cbxEtapaAtendimento.SelectedIndex = -1;
        }

        private void CarregarSituacaoAtendimento() 
        {
            var situacaoAtendimento = _atendimentoController.ListarSituacaoAtendimentos();
            cbxSituacaoAtendimento.DataSource = situacaoAtendimento;
            cbxSituacaoAtendimento.DisplayMember = "Nome";
            cbxSituacaoAtendimento .SelectedIndex = -1;
        }
    }
}
