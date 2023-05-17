namespace Pizzaria
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private DateTime dataInicial;

        public Form1()
        {
            InitializeComponent();
            
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            dataInicial = DateTime.Now;
            contadorHoras.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            var tempoDecorrido = DateTime.Now - dataInicial;
            lblTempoDecorrido.Text = DateTime.Now.ToString("HH:mm:ss");
            lstHistoricoHoraData.Items.Add(tempoDecorrido.ToString());
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
            //seleciona o item da lista que tem índice = 0, o primeiro da lista
            cboSabores.SelectedIndex = 0;

            //coloca o cursor no ComboBox
            cboSabores.Focus();

            //Deixa os CheckBox sem seleção
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //Deixa o RadioButto sem borda selecionado
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Declaração das Variáveis
            string strSabor;

            //Variável para identificar os pedidos            
            var identificador = new Random().Next(1000);

            //variável para concatenar os textos
            string strPedido = "Nº do Pedido: " + identificador.ToString();

            DateTime dataPedido = DateTime.Now;
            var tempoEspera = new TimeSpan();

            //Variável recebe o texto do ComboBox
            strSabor = cboSabores.Text;

            //Verifica se tem algum item do ComboBox selecionado por meio da propriedade Text
            //Se o texto for Nulo ou Vazio emite mensagem ao usuário e coloca o foco do cursor no ComboBox

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

            //Emite mensagem de formação do pedido
            MessageBox.Show(strPedido,
                            "Pizzaria",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            //Adicionar último pedido ao Histórico
            lstHistorico.Items.Add(strPedido);

            var tempoDecorrido = DateTime.Now - dataInicial;
            lstHistoricoHoraData.Items.Add(tempoDecorrido.ToString(@"hh\:mm\:ss"));
        }

        private void contadorHoras_Tick(object sender, EventArgs e)
        {
            //Atualize o Label com o tempo decorrido
            var tempoDecorrido = DateTime.Now - dataInicial;
            lblTempoDecorrido.Text = tempoDecorrido.ToString(@"hh\:mm\:ss");
        }
    }
}