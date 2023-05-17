namespace Pizzaria
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private DateTime dataInicial;
        private DateTime tempoInicialPedido;

        public Form1()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            dataInicial = DateTime.Now;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            //var tempoDecorrido = DateTime.Now - dataInicial;
            lblTempoDecorrido.Text = DateTime.Now.ToString("HH:mm:ss");

            //Percorre todos os itens da lista e atualiza o tempo decorrido
            for(int i = 0; i < lstHistoricoHoraData.Items.Count; i++)
            {
                var tempoPedido = DateTime.Now - tempoInicialPedido;
                lstHistoricoHoraData.Items[i] = tempoPedido.ToString(@"hh\:mm\:ss");

                if(tempoPedido.Seconds > 10)
                {
                    //lstHistoricoHoraData.(i, Color.Red);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Preenche o ComboBox com os sabores das Pizzas
            cboSabores.Items.Add("Selecione um sabor");
            cboSabores.Items.Add("Mussarela");
            cboSabores.Items.Add("Palmito");
            cboSabores.Items.Add("Atum");
            cboSabores.Items.Add("Calabresa");

            cboSabores.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //seleciona o item da lista que tem �ndice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;

            //coloca o cursor no ComboBox
            cboSabores.Focus();

            //Deixa os CheckBox sem sele��o
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //Deixa o RadioButto sem borda selecionado
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Declara��o das Vari�veis
            string strSabor;

            //Vari�vel para identificar os pedidos            
            var identificador = new Random().Next(1000);

            //vari�vel para concatenar os textos
            string strPedido = "N� do Pedido: " + identificador.ToString();

            //Vari�vel recebe o texto do ComboBox
            strSabor = cboSabores.Text;

            //Verifica se tem algum item do ComboBox selecionado por meio da propriedade Text
            //Se o texto for Nulo ou Vazio emite mensagem ao usu�rio e coloca o foco do cursor no ComboBox

            if (string.IsNullOrWhiteSpace(cboSabores.Text) ||
               cboSabores.Text.Equals("Selecione um sabor"))
            {
                MessageBox.Show("Selecione um sabor de Pizza!",
                                "Pizzaria",
                                MessageBoxButtons.OK);

                cboSabores.Focus();
                return;
            }

            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = strPedido + " \n- Mussarela";
                    break;
                case "Palmito":
                    strPedido = strPedido + " \n- Palmito";
                    break;
                case "Atum":
                    strPedido = strPedido + " \n- Atum";
                    break;
                case "Calabresa":
                    strPedido = strPedido + " \n- Calabresa";
                    break;
            }

            //Verifica os ingredientes

            if (chkAzeitona.Checked)
            {
                strPedido = strPedido + " \ncom Azeitonas";
            }

            if (chkCebola.Checked)
            {
                strPedido = strPedido + " \ncom Cebola";
            }

            //Verifica a borda
            if (rdbComBorda.Checked)
            {
                strPedido = strPedido + " \ncom Borda Recheada";
            }
            else
            {
                strPedido = strPedido + " \nsem Borda Recheada";
            }

            tempoInicialPedido = DateTime.Now;

            //Emite mensagem de forma��o do pedido
            MessageBox.Show(strPedido,
                            "Pizzaria",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            //Adicionar �ltimo pedido ao Hist�rico
            lstHistorico.Items.Add(strPedido);

            lstHistoricoHoraData.Items.Add(tempoInicialPedido.ToString(@"hh\:mm\:ss"));
        }
    }
}