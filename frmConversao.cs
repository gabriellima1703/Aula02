namespace Aula02
{
    public partial class frmConversao : Form
    {
        public frmConversao()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if ( this.cboTipoConversao.SelectedIndex== 0 )
                //selectec index significa a lista, começa pelo 0.
            {
                float kilo = 0 ;
                 if (float.TryParse(txtValorOriginal.Text, out kilo) )
                    //tryparse, tenta fazer parse. 
                {

                    float libras = (float)(kilo * 2.20462);
                    txtValorConvertido.Text = $"{libras:N2}";
                }
                else
                {
                    MessageBox.Show( "Valor inválido" );
                    txtValorConvertido.Text = "";
                }
            }
           else if (this.cboTipoConversao.SelectedIndex == 1)
            {

                {
                float libras = 0;
                if (float.TryParse(txtValorOriginal.Text, out libras))
                    {
                    float kilo = (float)(libras / 2.20462);
                    txtValorConvertido.Text = $"{kilo:N2}";
                }
                else
                    {
                    MessageBox.Show("Valor inválido");
                        txtValorConvertido.Text = "";
                    }
            }

            }
           else
            {
                MessageBox.Show("Selecione o tipo de conversão!");
            }
        }

        private void cboTipoConversao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}